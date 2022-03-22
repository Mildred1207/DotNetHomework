using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
	class Order
	{
		public int orderId { get; set; }
		public int orderTime { get; set; }
		public Client client { get; set; }
		public string paymentMethod { get; set; }
		public int paymentTime { get; set; }

		public OrderDetails[] orderDetails;

		public double sumValue { get; set; }

		public Order(int id,int otime,Client person,string payMethod,int paytime,OrderDetails[] odetails)
		{
			this.orderId = id;
			this.orderTime = otime;
			this.client = person;
			this.paymentMethod = payMethod;
			this.paymentTime = paytime;
			this.orderDetails = odetails;
		}

		public void CaculateValue()
		{
			foreach(OrderDetails o in orderDetails)
			{
				sumValue += o.good.goodValue * o.goodNum;
			}
		}

		public override bool Equals(object obj)
		{
			Order m = obj as Order;
			return (m != null 
				&& m.orderId == orderId 
				&& m.orderTime == orderTime 
				&& m.paymentMethod == paymentMethod 
				&& m.paymentTime == paymentTime
				&& m.sumValue == sumValue 
				&&EqualityComparer<Client>.Default.Equals(client, m.client)
				&&EqualityComparer<OrderDetails[]>.Default.Equals(orderDetails, m.orderDetails));
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string ToString()
		{
			return "orderId:" + orderId
				+ " orderTime:" + orderTime
				+ " clientName:" + client.clientName
				+ " paymentMethod" + paymentMethod
				+ " paymentTime" + paymentTime
				+ " SumValue:" + sumValue;
		}
	}
}
