using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Homework11
{
	public class OrderService
	{
		public OrderService()
		{
			using (var ctx = new OrderContext())
			{
				if (ctx.Goods.Count() == 0)
				{
					ctx.Goods.Add(new Good("魔杖", 100.0));
					ctx.Goods.Add(new Good("巫师袍", 200.0));
					ctx.SaveChanges();
				}
				if (ctx.Client.Count() == 0)
				{
					ctx.Client.Add(new Client("哈利波特"));
					ctx.Client.Add(new Client("德拉科马尔福"));
					ctx.SaveChanges();
				}
			}
		}

		public List<Order> Orders
		{
			get
			{
				using (var ctx = new OrderContext())
				{
					return ctx.Orders
					  .Include(o => o.OrderDetails.Select(d => d.Good))
					  .Include("Client")
					  .ToList<Order>();
				}
			}
		}

		//避免级联添加或修改Customer和Goods
		private static void FixOrder(Order newOrder)
		{
			newOrder.ClientID = newOrder.Client.Id;
			newOrder.Client = null;
			newOrder.OrderDetails.ForEach(d => {
				d.GoodsId = d.Good.Id;
				d.Good = null;
			});
		}

		public void AddOrder(Order order)
		{
			FixOrder(order);
			using (var ctx = new OrderContext())
			{
				ctx.Entry(order).State = EntityState.Added;
				ctx.SaveChanges();
			}
		}

		public void DeleteOrder(string orderId)
		{
			using (var ctx = new OrderContext())
			{
				var order = ctx.Orders.Include("OrderDetails")
				  .SingleOrDefault(o => o.OrderId == orderId);
				if (order == null) return;
				ctx.OrderDetails.RemoveRange(order.OrderDetails);
				ctx.Orders.Remove(order);
				ctx.SaveChanges();
			}
		}

		public void ChangeOrder(Order newOrder)
		{
			DeleteOrder(newOrder.OrderId);
			AddOrder(newOrder);
		}

		public Order QueryOrderId(string id)
		{
			using (var ctx = new OrderContext())
			{
				return ctx.Orders
				  .Include(o => o.OrderDetails.Select(d => d.Good))
				  .Include("Client")
				  .SingleOrDefault(o => o.OrderId == id);
			}
		}

		public List<Order> QueryOrderGoodName(string goodsName)
		{
			using (var ctx = new OrderContext())
			{
				return ctx.Orders
				  .Include(o => o.OrderDetails.Select(d => d.Good))
				  .Include("Client")
				  .Where(order => order.OrderDetails.Any(item => item.Good.GoodName == goodsName))
				  .ToList();
			}
		}

		public List<Order> QueryOrderClient(string clientname)
		{
			using (var ctx = new OrderContext())
			{
				return ctx.Orders
				  .Include(o => o.OrderDetails.Select(d => d.Good))
				  .Include("Client")
				  .Where(order => order.Client.ClientName == clientname)
				  .ToList();
			}
		}

		public object QuerySumValue(float amout)
		{
			using (var ctx = new OrderContext())
			{
				return ctx.Orders
				  .Include(o => o.OrderDetails.Select(d => d.Good))
				  .Include("Client")
				.Where(order => order.OrderDetails.Sum(d => d.GoodNum * d.Good.GoodValue) > amout)
				.ToList();
			}
		}

		public void Export(String fileName)
		{
			XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
			using (FileStream fs = new FileStream(fileName, FileMode.Create))
			{
				xs.Serialize(fs, Orders);
			}
		}

		public void Import(string path)
		{
			XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
			using (FileStream fs = new FileStream(path, FileMode.Open))
			{
				using (var ctx = new OrderContext())
				{
					List<Order> temp = (List<Order>)xs.Deserialize(fs);
					temp.ForEach(order => {
						if (ctx.Orders.SingleOrDefault(o => o.OrderId == order.OrderId) == null)
						{
							FixOrder(order);
							ctx.Orders.Add(order);
						}
					});
					ctx.SaveChanges();
				}
			}
		}
	}
}
