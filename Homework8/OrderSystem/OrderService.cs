using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Homework6
{
	public class OrderService
	{
		//需要进行静态初始化
		private readonly List<Order> Order = new List<Order>();
		public List<Order> OrderList { get => Order; }

		public OrderService(){
		}

		//排序
		public void SortOrder()
		{
			Order.Sort((Order p1, Order p2) => p1.OrderId.CompareTo(p2.OrderId));
		}
		//添加订单
		public void AddOrder(Order o)
		{
			if(o == null||(!(o.OrderId!=0&&o.OrderDetails!=null&&o.OrderDetails.Count>0)))
			{
				throw new ApplicationException("输入错误");
			}
			else if(Order.Contains(o))
			{
				throw new ApplicationException($"{o.OrderId}已经存在");
			}
			Order.Add(o);
		}

		//删除订单
		public void DeleteOrder(int id)
		{
			Order ordertem = QueryOrderId(id);
			if(ordertem == null)
			{
				throw new ApplicationException("要删除的订单不存在");
			}
			Order.RemoveAll(o => o.OrderId == id);
		}

		//修改订单
		public void ChangeOrder(Order o)
		{
			if (o == null || (!(o.OrderId != 0 && o.OrderDetails != null && o.OrderDetails.Count > 0)))
			{
				throw new ApplicationException("输入错误");
			}
			Order ordertem = QueryOrderId(o.OrderId);
			if(ordertem == null)
			{
				throw new ApplicationException("要修改的订单不存在");
			}
			Order.Remove(ordertem);
			Order.Add(o);
		}

		public List<Order> QueryAll()
		{
			return Order.OrderBy(o => o.SumValue).ToList<Order>();
		}

		//按照订单号、客户、订单金额等进行查询(查询操作不抛异常）
		public Order QueryOrderId(int id)
		{
			return Order.Where(o => o.OrderId == id).FirstOrDefault();
		}
		public List<Order> QueryOrderClient(string clientname)
		{
			var query = from o2 in Order
						where o2.Client.ClientName == clientname
						orderby o2.SumValue
						select o2;
			List<Order> result = query.ToList();
			if (result.Count > 0)
			{
				return result;
			}
			throw new IndexOutOfRangeException("查找失败");
		}
		public List<Order> QueryOrderSumValue(double sum)
		{
			var query = from o2 in Order
						where o2.SumValue == sum
						orderby o2.SumValue
						select o2;
			List<Order> result = query.ToList();
			if (result.Count > 0)
			{
				return result;
			}
			throw new IndexOutOfRangeException("查找失败");
		}

		public void Export(String fileName)
		{
			XmlSerializer xz = new XmlSerializer(typeof(List<Order>));
			using (FileStream fs = new FileStream(fileName, FileMode.Create))
			{
				xz.Serialize(fs, Order);
			}
		}

		public void Import(String path)
		{
			XmlSerializer xz = new XmlSerializer(typeof(List<Order>));
			using (FileStream fs = new FileStream(path, FileMode.Open))
			{
				List<Order> o = (List<Order>)xz.Deserialize(fs);
				o.ForEach(order =>
				{
					if (!Order.Contains(order))
					{
						Order.Add(order);
					}
				});
			}
		}
	}

}
