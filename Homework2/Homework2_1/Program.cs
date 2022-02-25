using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_1
{
	class Program
	{
		static void Main(string[] args)
		{
			String s;
			int a;
			Console.Write("Please input an integer: ");
			s = Console.ReadLine();
			a = Convert.ToInt32(s);
			putPrimNumber(a);
		}

		static void putPrimNumber(int x)
		{
			List<int> hundredList = new List<int>();
			getPrimNumber(hundredList,x);

			if (x <= 1)
			{
				Console.WriteLine("This number doesn't prim facter!");
				return;
			}

			for(int i = 0; i < hundredList.Count;i++) 
			{
				int n = hundredList[i];
				while (x % n == 0)
				{
					x = x / n;
					Console.Write("{0} ",n);
				}
				if (x * x < n)
					return;
			}

			Console.Write(x);
		}

		static void getPrimNumber(List<int> tmpList,int n)
		{
			tmpList.Add(2);
			int i, j = 0;
			for (i = 3; i <= n; i = i + 2)
			{
				for (j = 2; j*j <= i; j++)
				{
					if (i % j == 0)
						break;
				}
				if (j*j > i)
				{
					tmpList.Add(i);
				}
			}
		}
	}
}
