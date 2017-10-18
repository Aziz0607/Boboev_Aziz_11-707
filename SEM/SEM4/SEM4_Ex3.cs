/*
 * Автор программы: Бобоев Азизджон 11-707
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int q = 0;
            int d = q;
            int i;
            while (n != d)
            {
                d = 1;
                q += 1;
                i = q;
                while (i != 0)
                {
                    d = (i % 10) * d;
                    i /= 10;
                }
            }

            Console.WriteLine(q);
            Console.ReadKey();
        }
    }
}