using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());

            int result = 1;

            if (n != 0)
            {
                while (n != 0)
                {
                    if (n % k != 0)
                    {
                        result = result * (n % k);
                        n /= k;
                    }
                    else
                    {
                        result = 0;
                        break;
                    }
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}