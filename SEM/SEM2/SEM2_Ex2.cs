using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());

            int k = Convert.ToInt32(Console.ReadLine());

            int d = a2 - a1;
            int result = -1;
            if (k < 1)
            {
                Console.WriteLine(result);
            }
            else
            {
                result = a1 + (k - 1) * d;
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}