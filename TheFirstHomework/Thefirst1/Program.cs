using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thefirst1
{
	class Program
	{
		static void Main(string[] args)
		{
			string s1 = "", s2 = "";
			double d1 = 0, d2 = 0;
			//输入第一个数字
			Console.Write("Please input the first number: ");
			s1 = Console.ReadLine();
			d1 = Double.Parse(s1);
			//输入运算符
			Console.Write("Please input the operator: ");
			s2 = Console.ReadLine();
			//输入第二个数字
			Console.Write("Please input the second number: ");
			s1 = Console.ReadLine();
			d2 = Double.Parse(s1);
			switch (s2)
			{
				case "+":
					Console.WriteLine("{0}+{1}={2}", d1, d2, d1 + d2);
					break;
				case "-":
					Console.WriteLine("{0}-{1}={2}", d1, d2, d1 - d2);
					break;
				case "*":
					Console.WriteLine("{0}*{1}={2}", d1, d2, d1 * d2);
					break;
				case "/":
					if (d2 == 0)
					{
						Console.WriteLine("Error,program exits!");
					}
					else
					{
						Console.WriteLine("{0}/{1}={2}", d1, d2, d1 / d2);
					}
					break;
				default:
					Console.WriteLine("Error,program exits!");
					break;
			}
		}
	}
}
