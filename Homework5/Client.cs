using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
	class Client
	{
		public string clientName { get; set; }

		public Client(string name)
		{
			this.clientName = clientName;
		}

		public override bool Equals(object obj)
		{
			Client m = obj as Client;
			return m != null && m.clientName == clientName;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		public override string ToString()
		{
			return "clientname : "+clientName;
		}
	}
}
