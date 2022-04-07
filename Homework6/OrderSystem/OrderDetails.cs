using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
	[Serializable]
	public class OrderDetails
	{
		public Good Good { get; set; }
		public int GoodNum { get; set; }

		public OrderDetails()
		{

		}
		public OrderDetails(Good g,int gn)
		{
			this.Good = g;
			this.GoodNum = gn;
		}

		public int Amount { get => Good.GoodValue * GoodNum; }
		public override bool Equals(object obj)
		{
			var m = obj as OrderDetails;
			return m!=null && m.GoodNum ==GoodNum && EqualityComparer<Good>.Default.Equals(Good, m.Good);
		}

		public override int GetHashCode()
		{
			return EqualityComparer<Good>.Default.GetHashCode(Good);
		}

		public override string ToString()
		{
			return $"goodname:{Good.GoodId},goodnum:{Good.GoodValue}";
		}
	}
}
