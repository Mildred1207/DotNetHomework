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
			Console.Write("Please input an integer more than 2: ");
			s = Console.ReadLine();
			a = Convert.ToInt32(s);
			List<int> primNumber = new List<int>();
			putPrimNumber(a,primNumber);
			foreach(int i in primNumber)
			{
				Console.Write(i + " ");
			}
		}

		static List<int> putPrimNumber(int x,List<int> primNumber)
		{
			List<int> hundredList = new List<int>();
			getPrimNumber(hundredList,x);

			if (x <= 1)
			{
				throw new AccessViolationException("You should never enter a number less than 2!");
			}

			for(int i = 0; i < hundredList.Count;i++) 
			{
				int n = hundredList[i];
				while (x % n == 0)
				{
					x = x / n;
					primNumber.Add(n);
				}
				if (x * x < n)
					break;
			}
			if (x >= 2)
			{
				primNumber.Add(x);
			}
			return primNumber;
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
