using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
	[Serializable]
	public class Client
	{
		public string ClientName { get; set; }

		public Client()
		{

		}
		public Client(string name)
		{
			this.ClientName = name;
		}

		public override bool Equals(object obj)
		{
			var m = obj as Client;
			return ClientName != null && ClientName == m.ClientName;
		}

		public override string ToString()
		{
			return $"clientname :{ClientName}";
		}

		public override int GetHashCode()
		{
			return ClientName.GetHashCode();
		}
	}
}