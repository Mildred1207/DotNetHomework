using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_4
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] testArray = { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };
			bool res = isToeplitzMatrix(testArray);
			Console.WriteLine(res);
		}

		static bool isToeplitzMatrix(int[,] a)
		{
			for(int i = 0; i < a.GetLength(0)-1; i++)
			{
				for(int j = 0; j < a.GetLength(1)-1; j++)
				{
					if (a[i + 1, j + 1] != a[i, j])
						return false;
				}
			}
			return true; 
		}
	}
}
