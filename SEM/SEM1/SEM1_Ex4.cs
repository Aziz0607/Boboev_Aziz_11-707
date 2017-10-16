using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
	class Program
	{
		static void Main(string[] args)
		{
			int x1 = Convert.ToInt32(Console.ReadLine());
			int y1 = Convert.ToInt32(Console.ReadLine());

			int x2 = Convert.ToInt32(Console.ReadLine());
			int y2 = Convert.ToInt32(Console.ReadLine());

			if (x1 == x2)
			{
				if (y2 <= 8 && y2 != y1)
				{
					Console.WriteLine("YES");
				}
				else
				{
					Console.WriteLine("NO");
				}
			}
			else if (y1 == y2)
			{
				if (x2 <= 8 && x2 != x1)
				{
					Console.WriteLine("YES");
				}
				else
				{
					Console.WriteLine("NO");
				}
			}
			else
			{
				Console.WriteLine("NO");
			}
			Console.ReadKey();
		}
	}
}