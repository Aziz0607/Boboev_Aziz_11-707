/*
 * Автор программы: Бобоев Азизджон 11-707
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n");
            int n = Convert.ToInt32(Console.ReadLine());

            bool flag = true;

            int a;
            int b;

            if (n < 1)
            {
                Console.WriteLine(-1);
            }
            else if (n < 2)
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                flag = a > b ? true : false;
                Console.WriteLine(flag);
            }
            else
            {
                for (int i = 0; i < n - 1; i++)
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    flag = a > b ? true : false;
                    if (!flag)
                    {
                        Console.WriteLine(flag);
                        break;
                    }
                }
            }
        }
    }
}