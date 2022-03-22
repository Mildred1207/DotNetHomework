using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
	class OrderDetails
	{
		public Good good { get; set; }
		public int goodNum;

		public OrderDetails(Good g,int gn)
		{
			this.good = g;
			this.goodNum = gn;
		}

		public override bool Equals(object obj)
		{
			OrderDetails m = obj as OrderDetails;
			return m!=null && m.goodNum ==goodNum && EqualityComparer<Good>.Default.Equals(good, m.good);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string ToString()
		{
			return "goodname: "+good.goodId+" goodnum: "+good.goodValue;
		}
	}
}
