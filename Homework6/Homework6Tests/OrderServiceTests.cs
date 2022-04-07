using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework6.Tests
{
	[TestClass()]
	public class OrderServiceTests
	{
		OrderService orderService = new OrderService();

		Client client1;
		Client client2;
		Client client3;

		Good good1;
		Good good2;
		Good good3;

		OrderDetails orderDetails1;
		OrderDetails orderDetails2;
		OrderDetails orderDetails3;

		Order order1;
		Order order2;
		Order order3;

		[TestInitialize]
		public void Init()
		{
			client1 = new Client("哈利波特");
			client2 = new Client("德拉科马尔福");
			client3 = new Client("西弗勒斯斯内普");

			good1 = new Good(1, 100);
			good2 = new Good(2, 200);
			good3 = new Good(3, 300);

			orderDetails1 = new OrderDetails(good1, 10);
			orderDetails2 = new OrderDetails(good2, 20);
			orderDetails3 = new OrderDetails(good3, 5);

			order1 = new Order(1, 20220321, client1);
			order2 = new Order(2, 20220312, client2);
			order3 = new Order(3, 20220303, client3);

			order1.AddDetails(orderDetails1);
			order1.AddDetails(orderDetails2);
			order2.AddDetails(orderDetails1);
			order2.AddDetails(orderDetails3);
			order3.AddDetails(orderDetails3);
			order3.AddDetails(orderDetails2);

			orderService = new OrderService();
			orderService.AddOrder(order1);
			orderService.AddOrder(order2);
			orderService.AddOrder(order3);
		}

		[TestMethod()]
		public void SortOrderTest()
		{
			Order test = new Order(1, 20220321, client1); ;
			test.AddDetails(orderDetails2);
			test.AddDetails(orderDetails1);
			orderService.SortOrder();
			Assert.AreEqual(test, order1);
		}

		[TestMethod()]
		public void AddOrderTest()
		{
			Order order4 = new Order(4, 20220401, client1);
			order4.AddDetails(new OrderDetails(good2, 22));
			orderService.AddOrder(order4);
			List<Order> orders = orderService.QueryAll();
			Assert.AreEqual(4, orders.Count);
			CollectionAssert.Contains(orders, order4);
		}

		[TestMethod]
		[ExpectedException(typeof(ApplicationException))]
		public void AddOrdertest1()
		{
			Order order4 = new Order(3, 20220401, client2);
			orderService.AddOrder(order4);
		}

		[TestMethod]
		[ExpectedException(typeof(ApplicationException))]
		public void AddOrdertest2()
		{
			Order order4 = new Order(3, 20220303, client3);
			order3.AddDetails(orderDetails3);
			order3.AddDetails(orderDetails2);
			orderService.AddOrder(order4);
		}

		[TestMethod()]
		public void DeleteOrderTest()
		{
			orderService.DeleteOrder(2);
			List<Order> orders = orderService.QueryAll();
			Assert.AreEqual(2, orders.Count);
		}

		[TestMethod()]
		[ExpectedException(typeof(ApplicationException))]
		public void DeleteOrderTest1()
		{
			orderService.DeleteOrder(10);
		}

		[TestMethod()]
		public void ChangeOrderTest()
		{
			Order order3 = new Order(3, 20220303, client2);
			order3.AddDetails(new OrderDetails(good3, 22));
			orderService.ChangeOrder(order3);
			List<Order> orders = orderService.QueryAll();
			Assert.AreEqual(3, orders.Count);
			Order o = orderService.QueryOrderId(3);
			Assert.AreEqual(client2, o.Client);
		}

		

		[TestMethod()]
		[ExpectedException(typeof(ApplicationException))]
		public void ChangeOrderTest1()
		{
			Order order4 = new Order(4, 20220303, client2);
			order4.AddDetails(new OrderDetails(good3, 22));
			orderService.ChangeOrder(order4);
		}

		[TestMethod()]
		[ExpectedException(typeof(ApplicationException))]
		public void ChangeOrderTest2()
		{
			Order order4 = new Order(0, 20220303, client2);
			order4.AddDetails(new OrderDetails(good3, 22));
			orderService.ChangeOrder(order4);
		}

		[TestMethod()]
		public void QueryOrderIdTest()
		{
			Order order2 = orderService.QueryOrderId(2);
			Assert.AreEqual(2, order2.OrderId);
			Assert.AreEqual(20220312, order2.OrderTime);
			Assert.AreEqual(client2, order2.Client);
			List<OrderDetails> details = new List<OrderDetails>(){ orderDetails1,orderDetails3};
			CollectionAssert.AreEqual(details, order2.OrderDetails);
		}

		[TestMethod()]
		public void QueryOrderClientTest()
		{
			List<Order> test = orderService.QueryOrderClient("德拉科马尔福");
			Assert.AreEqual(1, test.Count);
		}

		[TestMethod()]
		public void QueryOrderSumValueTest()
		{
			List<Order> test = orderService.QueryOrderSumValue(5000);
			Assert.AreEqual(1, test.Count);
		}

		[TestMethod()]
		public void ExportAndImportTest()
		{
			string filename = "test.xml";
			orderService.Export(filename);
			var orderService1 = new OrderService();
			orderService1.Import(filename);
			File.Delete(filename);
			CollectionAssert.AreEqual(orderService.QueryAll().ToList(), orderService1.QueryAll().ToList());
		}
	}
}
