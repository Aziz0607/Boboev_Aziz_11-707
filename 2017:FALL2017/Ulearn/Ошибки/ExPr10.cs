using System;
namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            int count = 1000 / 3 + 1000 / 5 - 1000 / (3 * 5);
            Console.WriteLine("Количество чисел! {0}",count);
        }
    }
}