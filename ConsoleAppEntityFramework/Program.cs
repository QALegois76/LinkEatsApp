// See https://aka.ms/new-console-template for more information
using ConsoleAppEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System.Diagnostics;

namespace ConsoleAppEntityFramework
{
	class Program
	{
		public static Random rand = new Random();
		public static Stopwatch stopwatch = new Stopwatch();

		public static void Main(string[] args)
		{
			EFContext context = new EFContext();

			//List<long> times = new List<long>();

			//EState[] states = (EState[])Enum.GetValues(typeof(EState));

			//for (int i = 0; i < 100; i++)
			//{
			//	stopwatch.Restart();
			//	stopwatch.Stop();
			//	times.Add(stopwatch.ElapsedMilliseconds);
			//}
			//stopwatch.Restart();
			//context.SaveChanges();
			//stopwatch.Stop();

			//Console.WriteLine("item add in data base in : "+times.Average());
			//Console.WriteLine("database saved in: " + stopwatch.ElapsedMilliseconds);

		}
	}

}

