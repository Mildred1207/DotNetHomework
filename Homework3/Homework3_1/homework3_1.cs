using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_1
{
	public interface Shape
	{
		double area();
		void judge();
	}

	public class Rectangle: Shape
	{
		private readonly double width;
		private readonly double height;

		public Rectangle(double width,double height)
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
			if (side< 0)
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
			if (side1 + side2 < side3 || side3 + side2 < side2 || side1 + side3 < side2 || side1<0 || side2<0 || side3<0)
			{
				throw new AccessViolationException("These three side can't construct a trianle");
			}
		}

		public double area()
		{
			return Math.Sqrt(((side1+side2+ side3)/2)* 
				((-side1 + side2 + side3) / 2)* 
				((side1 - side2 + side3) / 2) * 
				((side1 + side2 - side3) / 2));
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Rectangle r = new Rectangle(5,4);
			r.judge();
			Console.WriteLine(r.area());
			Square s = new Square(5);
			s.judge();
			Console.WriteLine(s.area());
			Triangle t1 = new Triangle(3, 4, 5);
			t1.judge();
			Console.WriteLine(t1.area());
			Triangle t2 = new Triangle(3, 4, 8);
			t2.judge();
			Console.WriteLine(t2.area());
		}
	}
}
