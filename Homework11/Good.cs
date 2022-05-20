using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
	public class Good
	{
		public string Id { get; set; }
		public string GoodName { get; set; }
		public double GoodValue { get; set; }

		public Good()
		{
			Id = Guid.NewGuid().ToString();
		}

		public Good(string name, double price) : this()
		{
			GoodName = name;
			GoodValue = price;
		}

		public override bool Equals(object obj)
		{
			var m = obj as Good;
			return m != null &&Id == m.Id && GoodName == m.GoodName;
		}

		public override int GetHashCode()
		{
			return Id.GetHashCode();
		}

		public override string ToString()
		{
			return $"goodid: {Id},goodvalue: {GoodValue}";
		}
	}


}
