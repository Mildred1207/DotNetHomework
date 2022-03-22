using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
	class OrderService
	{
		public List<Order> order = new List<Order>();

		public OrderService(List<Order> o)
		{
			this.order = o;
		}

		//输出
		public override string ToString()
		{
			string s = "";
			foreach(Order o in order)
			{
				s += o.ToString();
			}
			return s;
		}

		//排序
		public void sortOrder()
		{
			order.Sort((Order p1, Order p2) => p1.orderId.CompareTo(p2.orderId));
		}
		//添加订单
		public void addOrder(Order o)
		{
				order.Add(o);
		}

		//删除订单
		public void deleteOrder(int id)
		{
			int i = 0;
			try
			{
				foreach (Order o in order)
				{
					if (o.orderId == id)
					{
						order.RemoveAt(i);
					}
					i++;
				}
			}
			catch
			{
				throw new IndexOutOfRangeException("删除失败");
			}
		}

		//修改订单
		public void changeOrder(Order o,int id)
		{
			int i = 0;
			try
			{
				foreach (Order o1 in order)
				{
					if (o1.orderId == id)
					{
						order[i] = o;
					}
					i++;
				}
			}
			catch
			{
				throw new IndexOutOfRangeException("修改失败");
			}
		}

		//按照订单号、客户、订单金额等进行查询
		public Order queryOrderId(int id)
		{
			IEnumerable<Order> query = from o2 in order
						where o2.orderId == id
						select o2;
			return (Order)query;
		}
		public List<Order> queryOrderClient(string clientname)
		{
			var query = from o2 in order
						where o2.client.clientName == clientname
						orderby o2.sumValue
						select o2;
			return query.ToList();
		}

		public List<Order> queryOrderSumValue(double sum)
		{
			var query = from o2 in order
						where o2.sumValue == sum
						orderby o2.sumValue
						select o2;
			return query.ToList();
		}
	}

}
