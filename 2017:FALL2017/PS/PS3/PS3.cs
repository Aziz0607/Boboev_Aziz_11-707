using System;
using System.Numerics;
namespace EasyEasy
{

    class Program
    {
        public static string Do(BigInteger n, int p)
        {
            string str = null;
            int k = 0;
            if (n >= p)
            {
                str += Do((int)n / p, p);
            }
            k = (int)Math.Floor((decimal)BigInteger.ModPow(n, 1, p));

            if (k > 9)
                str += ((char)(k + 55)).ToString();
            else str += k.ToString();

            return str;
        }

        static void Main(string[] args)
        {
            int p;
            Console.WriteLine("Введите основание системы счисления: ");
            p = int.Parse(Console.ReadLine());
            BigInteger n;
            Console.WriteLine("Введите число: ");
            n = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(Do(n, p));
            Console.ReadLine();
        }
    }
}