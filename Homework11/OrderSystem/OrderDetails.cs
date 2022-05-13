using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
	public class OrderDetails
	{

		public string Id { get; set; }

		public int Index { get; set; } //序号

		public string GoodsId { get; set; }

		public Good Good { get; set; }

		public String GoodName { get => Good != null ? this.Good.GoodName : ""; }

		public double UnitPrice { get => Good != null ? this.Good.GoodValue : 0.0; }

		public string OrderId;

		public int GoodNum { get; set; }

		public OrderDetails()
		{
			Id = Guid.NewGuid().ToString();
		}

		public OrderDetails(int index, Good goods, int quantity)
		{
			this.Index = index;
			this.Good = goods;
			this.GoodNum = quantity;
		}

		public double Amount{get => Good == null ? 0.0 : Good.GoodValue * GoodNum;}
		public override bool Equals(object obj)
		{
			var m = obj as OrderDetails;
			return m != null && GoodName == m.GoodName;
		}

		public override int GetHashCode()
		{
			return EqualityComparer<Good>.Default.GetHashCode(Good);
		}

		public override string ToString()
		{
			return $"goodname:{Good.Id},goodnum:{Good.GoodValue}";
		}
	}
}
