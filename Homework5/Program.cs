using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
	class Program
	{
		static void Main(string[] args)
		{
			Client client1 = new Client("哈利波特");
			Client client2 = new Client("德拉科马尔福");
			Client client3 = new Client("西弗勒斯斯内普");

			Good good1 = new Good(1, 100);
			Good good2 = new Good(2, 200);
			Good good3 = new Good(3, 300);

			OrderDetails orderDetails1 = new OrderDetails(good1, 10);
			OrderDetails orderDetails2 = new OrderDetails(good2, 20);
			OrderDetails orderDetails3 = new OrderDetails(good3, 5);

			OrderDetails[] orderDetails4 = { orderDetails1, orderDetails2 };
			OrderDetails[] orderDetails5 = { orderDetails2, orderDetails3 };
			OrderDetails[] orderDetails6 = { orderDetails1, orderDetails3 };

			Order order1 = new Order(1, 20220321, client1, "支付宝", 20220322, orderDetails4);
			Order order2 = new Order(2, 20220312, client2, "微信", 20220320, orderDetails5);
			Order order3 = new Order(3, 20220303, client3, "云闪付", 20220310, orderDetails6);

			List<Order> orderList = new List<Order>{ order2, order1 };
			OrderService orderService = new OrderService(orderList);

			Console.WriteLine("订单表：" + orderService.ToString());
			orderService.sortOrder();
			Console.WriteLine("排序后的订单表：" + orderService.ToString());
			orderService.addOrder(order3);
			Console.WriteLine("加入订单3后的订单表：" + orderService.ToString());
			orderService.deleteOrder(3);
			Console.WriteLine("删除订单3后的订单表：" + orderService.ToString());
			orderService.changeOrder(order3,1);
			Console.WriteLine("讲订单1改为订单3后的订单表：" + orderService.ToString());
			Console.WriteLine("按订单号查询后：" + orderService.queryOrderId(2).ToString());
			List<Order> orderList1 = new List<Order> ();
			orderList1 = orderService.queryOrderClient("德拉科马尔福");
			OrderService orderService1 = new OrderService(orderList1);
			Console.WriteLine("按客户查询后：" + orderService1.ToString());
			Console.WriteLine("按总价查询后：" + orderService.queryOrderSumValue(5000).ToString());
		}
	}
}
