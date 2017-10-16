using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = Convert.ToInt32(Console.ReadLine());

            int n = 1;
            if (k < 1)
            {
                Console.WriteLine(-1);
            }
            else if (k < 2)
            {
                Console.WriteLine(n);
            }
            else
            {
                while (k != 1)
                {
                    bool flag = true;
                    n += 1;
                    for (int i = 2; i <= n / 2 && flag; i++)
                    {
                        if (n % i == 0) { flag = false; }
                    }
                    if (flag)
                    {
                        k--;
                    }
                }
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}