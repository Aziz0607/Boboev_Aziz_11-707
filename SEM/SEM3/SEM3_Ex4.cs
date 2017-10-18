/*
 * Автор программы: Бобоев Азизджон 11-707
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n");
            int n = Convert.ToInt32(Console.ReadLine());

            double s;
            if (n != 0)
            {
                Console.WriteLine("Enter par of triangle");
                s = Convert.ToDouble(Console.ReadLine()) * Convert.ToDouble(Console.ReadLine()) * 0.5;
                n -= 1;
                while (n != 0)
                {
                    Console.WriteLine("Next triangle");
                    double next = Convert.ToDouble(Console.ReadLine()) * Convert.ToDouble(Console.ReadLine()) * 0.5;
                    if (next < s) { s = next; }
                    n -= 1;
                }
                Console.WriteLine("Answer: " + s);
            }
            else Console.WriteLine("Answer: -1");

            Console.ReadKey();
        }
    }
}