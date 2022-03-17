using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Homework4_2
{
	class Clock
	{
		public delegate void TickEventHandler(Clock sender,DateTime date);
		public event TickEventHandler TickEvent;

		public delegate void AlarmEventHandler(Clock sender);
		public event AlarmEventHandler AlarmEvent;

		public Clock(DateTime alarmTime)
		{
			AlarmTime = alarmTime;
		}
		public DateTime AlarmTime { get; set; }

		public void Run()
		{
			while (true)
			{
				TickEvent(this,DateTime.Now);
				if (DateTime.Compare(DateTime.Now, AlarmTime) >= 0)
				{
					AlarmEvent(this);
				}
				Thread.Sleep(1000);
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter the number of seconds after the alarm will ring: ");
			DateTime d1 = DateTime.Now.AddSeconds(Convert.ToDouble(Console.ReadLine()));
			Clock clock1 = new Clock(d1);
			clock1.TickEvent += ShowTime;
			clock1.AlarmEvent += Alarm;
			new Thread(clock1.Run).Start();
		}

		public static void ShowTime(Clock sender,DateTime dateTime)
		{
			Console.WriteLine("Tick Event: " + dateTime.ToLongTimeString().ToString());
		}

		public static void Alarm(Clock sender)
		{
			Console.WriteLine("Alarm Event: " +DateTime.Now.ToLongTimeString().ToString());
		}
	}
}

