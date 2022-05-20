using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Homework12.Models
{ 
    /**
     **/
    public class Order : IComparable<Order>
    {

        public string OrderId { get; set; }

        public string ClientID { get; set; }

        public Client Client { get; set; }

        public string ClientName { get => (Client != null) ? Client.ClientName : ""; }

        public DateTime OrderTime { get; set; }

        public List<OrderDetails> OrderDetails { get; set; }

        public Order()
        {
            OrderId = Guid.NewGuid().ToString();
            OrderDetails = new List<OrderDetails>();
            OrderTime = DateTime.Now;
        }

        public Order(string orderId, Client customer, List<OrderDetails> items) : this()
        {
            this.OrderId = orderId;
            this.Client = customer;
            this.OrderDetails = items;
        }

        public double SumValue
        {
            get => OrderDetails.Sum(d => d.Amount);
        }

        public void AddDetails(OrderDetails orderDetail)
        {
            if (this.OrderDetails.Contains(orderDetail))
            {
                throw new ApplicationException("已存在");
            }
            OrderDetails.Add(orderDetail);
        }

        public void DeleteDetails(OrderDetails orderDetail)
        {
            OrderDetails.Remove(orderDetail);
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null && OrderId == order.OrderId;
        }

        public override int GetHashCode()
        {
            return OrderId.GetHashCode();
        }

        public int CompareTo(Order other)
        {
            if (other == null) return 1;
            return this.OrderId.CompareTo(other.OrderId);
        }

        public override string ToString()
        {
            return $"orderId:{OrderId},orderTime:{OrderTime},clientName:{Client.ClientName},SumValue:{SumValue}";
        }
    }
}
