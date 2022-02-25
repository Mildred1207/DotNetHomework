using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_2
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = {11,23,34,56,78,98,112,24,5,6,89,0};
			int max = 0, min = 0, average = 0, sum = 0;
			getMostValue(numbers,ref max,ref min,ref average,ref sum);
			Console.WriteLine("max:{0},min:{1},average:{2},sum:{3}", max, min, average, sum);
		}
		
		static void getMostValue(int[] a,ref int max,ref int min,ref int average,ref int sum)
		{
			Array.Sort(a);
			min = a[0];
			max = a[a.Length - 1];
			for(int i = 0; i < a.Length-1; i++)
			{
				sum += a[i] + a[i + 1];
			}
			average = sum / a.Length;
		}
	}
}
