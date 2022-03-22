using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
	class Good
	{
		public int goodId { get; set; }
		public int goodValue { get; set; }

		public Good(int id,int value)
		{
			this.goodId = id;
			this.goodValue = value;
		}
		public override bool Equals(object obj)
		{
			Good m = obj as Good;
			return (m != null && m.goodId == goodId && m.goodValue == goodValue);
		}
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string ToString()
		{
			return "goodid: " + goodId + " goodvalue: " + goodValue;
		}
	}
}
