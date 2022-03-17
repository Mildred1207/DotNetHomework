using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_1
{
	class Program
	{
		//链表节点
		public class Node<T>
		{
			public Node<T> Next { get; set; }
			public T Data { get; set; }

			public Node(T t)
			{
				Next = null;
				Data = t;
			}
		}

		//泛型链表类
		public class GenericList<T>
		{
			private Node<T> head;
			private Node<T> tail;

			public GenericList()
			{
				tail = head = null;
			}

			public Node<T> Head
			{
				get => head;
			}

			public void Add(T t)
			{
				Node<T> n = new Node<T>(t);
				if (tail == null)
				{
					head = tail = n;
				}
				else
				{
					tail.Next = n;
					tail = n;
				}
			}

			public void ForEach(Action<T> action)
			{
				for(Node<T> n = head; n != null;n = n.Next)
				{
					action(n.Data);
				}
			}
		}


		static void Main(string[] args)
		{
			GenericList<int> intList = new GenericList<int>();
			for (int x = 0; x < 10; x++)
			{
				intList.Add(x);
			}
			//打印链表元素
			intList.ForEach(n => Console.Write(n+" "));
			//求最大值，最小值，求和
			int min = intList.Head.Data, max = intList.Head.Data,sum = 0;
			intList.ForEach(n =>
			{
				min = (n < min) ? n : min;
				max = (n > max) ? n : max;
				sum += n;
			});
			Console.WriteLine("min: " + min + " max: " + max + " sum: " + sum);
		}
	}
}
