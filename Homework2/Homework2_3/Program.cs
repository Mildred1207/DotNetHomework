using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_3
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> hundredList = new List<int>();
			for(int i = 2; i <= 100; i++)
			{
				hundredList.Add(i);
			}
			Eratosthenes(hundredList);
			foreach (int i in hundredList)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine("");
		}

		static List<int> Eratosthenes(List<int> tmpList)
		{
			for (int i = 0; i < tmpList.Count;)
			{
				if ((tmpList[i] % 2 == 0 && tmpList[i]!=2)||
					(tmpList[i] % 3 == 0 && tmpList[i] != 3 )|| 
					(tmpList[i] % 5 == 0 && tmpList[i] != 5 )|| 
					(tmpList[i] % 7 == 0 && tmpList[i] != 7))
				{
					tmpList.RemoveAt(i);
				}
				else
				{
					i++;
				}
			}
			return tmpList;
		}
	}
}
