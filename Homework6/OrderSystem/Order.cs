using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
	[Serializable]
	public class Order
	{
		public int OrderId { get; set; }
		public int OrderTime { get; set; }
		public Client Client { get; set; }
		
		public List<OrderDetails> OrderDetails { get; } = new List<OrderDetails>();

		public double SumValue
		{
			get => OrderDetails.Sum(d => d.Amount);
		}

		public Order()
		{
			this.OrderTime = 00000000;
		}

		public Order(int id,int otime,Client person)
		{
			this.OrderId = id;
			this.OrderTime = otime;
			this.Client = person;
		}

		public void AddDetails(OrderDetails orderDetail)
		{
			if (this.OrderDetails.Contains(orderDetail))
			{
				throw new ApplicationException("已存在");
			}
			OrderDetails.Add(orderDetail);
		}

		public override bool Equals(object obj)
		{
			var m = obj as Order;
			return m != null && m.OrderId == OrderId;
		}

		public override int GetHashCode()
		{
			return OrderId.GetHashCode();
		}

		public override string ToString()
		{
			return $"orderId:{OrderId},orderTime:{OrderTime},clientName:{Client.ClientName},SumValue:{SumValue}";
		}
	}
}
