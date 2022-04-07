using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
	[Serializable]
	public class Good
	{
		public int GoodId { get; set; }
		private int goodValue;

		public int GoodValue
		{
			get { return goodValue; }
			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("输入了非法的价格");
				}
				goodValue = value;
			}
		}
		
		public Good()
		{

		}
		public Good(int id,int value)
		{
			this.GoodId = id;
			this.goodValue = value;
		}
		public override bool Equals(object obj)
		{
			var m = obj as Good;
			return (m != null && m.GoodId == GoodId);
		}
		public override int GetHashCode()
		{
			return GoodId.GetHashCode();
		}

		public override string ToString()
		{
			return $"goodid: {GoodId},goodvalue: {GoodValue}";
		}
	}
}
