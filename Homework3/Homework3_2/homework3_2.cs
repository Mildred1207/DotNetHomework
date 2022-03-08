using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_2
{
	class homework3_2
	{
		public class Factory
		{
			public interface Shape
			{
				double area();
				void judge();
			}

			public class Rectangle : Shape
			{
				private readonly double width;
				private readonly double height;

				public Rectangle(double width, double height)
				{
					this.width = width;
					this.height = height;
				}
				public void judge()
				{
					if (width < 0 || height < 0)
					{
						throw new AccessViolationException("These three side can't construct a rectangle!");
					}
				}
				public double area()
				{
					return width * height;
				}

			}
			public class Square : Rectangle
			{
				private static double side;

				public Square(double side) : base(side, side)
				{
				}

				public new void judge()
				{
					if (side < 0)
					{
						throw new AccessViolationException("These three side can't construct a square!");
					}
				}
			}

			public class Triangle : Shape
			{
				private double side1, side2, side3;

				public Triangle(double side1, double side2, double side3)
				{
					this.side1 = side1;
					this.side2 = side2;
					this.side3 = side3;
				}
				public void judge()
				{
					if (side1 + side2 < side3 || side3 + side2 < side2 || side1 + side3 < side2 || side1 < 0 || side2 < 0 || side3 < 0)
					{
						throw new AccessViolationException("These three side can't construct a trianle");
					}
				}

				public double area()
				{
					return Math.Sqrt(((side1 + side2 + side3) / 2) *
						((-side1 + side2 + side3) / 2) *
						((side1 - side2 + side3) / 2) *
						((side1 + side2 - side3) / 2));
				}
			}
			public int[] GetInformation(String str)
			{
				string[] sArray = str.Split(',');
				int[] iArray = Array.ConvertAll<string, int>(sArray, s => int.Parse(s));
				Array.Sort(iArray);
				return iArray;
			}

			public double GetRandomNumber(double minimum, double maximum, int Len)  
			{
				Random random = new Random();
				return Math.Round(random.NextDouble() * (maximum - minimum) + minimum, Len);
			}

			public double GetArea(int[] n)
			{
				double sum = 0;
				foreach(int i in n)
				{
					switch (n[i])
					{
						case 1:
							Rectangle r = new Rectangle(GetRandomNumber(0,100,2), GetRandomNumber(0, 100, 2));
							sum += r.area();
							break;
						case 2:
							Square s = new Square(GetRandomNumber(0, 100, 2));
							sum += s.area();
							break;
						case 3:
							Triangle t = new Triangle(GetRandomNumber(0, 100, 2), GetRandomNumber(0, 100, 2), GetRandomNumber(0, 100, 2));
							sum += t.area();
							break;
						default:
							throw new AccessViolationException("Invalid input!");
					}
				}
				return sum;
			}
		}
		static void Main(string[] args)
		{
			Console.WriteLine("please enter 10 shapes,1 indicates a rectangle,2 indicates a square,3 indicates a triangle.Separate each shape with a comma");
			String s1 = Console.ReadLine();
			Factory f1 = new Factory();
			int[] i1 = f1.GetInformation(s1);
			Console.WriteLine(f1.GetArea(i1));
		}
	}
}
