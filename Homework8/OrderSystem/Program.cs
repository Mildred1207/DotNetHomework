using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
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

			Order order1 = new Order(1, 20220321, client1);
			Order order2 = new Order(2, 20220312, client2);
			Order order3 = new Order(3, 20220303, client3);

			order1.AddDetails(orderDetails1);
			order1.AddDetails(orderDetails2);
			order2.AddDetails(orderDetails1);
			order2.AddDetails(orderDetails3);
			order3.AddDetails(orderDetails3);
			order3.AddDetails(orderDetails2);

			OrderService orderService = new OrderService();
			orderService.AddOrder(order1);
			orderService.AddOrder(order2);
			orderService.AddOrder(order3);
			
			Console.WriteLine("按订单号查询后：");
			Console.WriteLine(orderService.QueryOrderId(1));
			Console.WriteLine(orderService.QueryOrderId(2));

			Console.WriteLine("输出所有的订单：");
			List<Order> orders = orderService.QueryAll();
			orders.ForEach(o => Console.WriteLine(o));

			Console.WriteLine("按客户查询后：");
			orders = orderService.QueryOrderClient("德拉科马尔福");
			orders.ForEach(o => Console.WriteLine(o));

			Console.WriteLine("按总价查询后：");
			orders = orderService.QueryOrderSumValue(5000);
			orders.ForEach(o => Console.WriteLine(o));

			Console.WriteLine("删除订单2后的订单表：");
			orderService.DeleteOrder(2);
			orderService.QueryAll().ForEach(o => Console.WriteLine(o));

			Console.WriteLine("排序后的订单表：");
			orderService.SortOrder();
			orderService.QueryAll().ForEach(o => Console.WriteLine(o));
		}
	}
}
