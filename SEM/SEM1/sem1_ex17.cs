/*
 * Автор программы: Бобоев Азизджон 11-707
 * 
 * Описание:
 *  Проверить, является ли билет «почти счастливым» по питерски [следующий или
 * предыдущий к счастливому (abcdef=>a+c+e=b+d+f)]
*/

using System;

namespace ConsoleApp
{
    class IsTicketHappines
    {
        public static void Main(string[] args)
        {
            
            int ticketNumber = Convert.ToInt32(Console.ReadLine()),
            firstTicketPart = ticketNumber/100000 + ticketNumber%10000/1000 + ticketNumber%100/10,
            secondTicketPart = ticketNumber%100000/10000 + ticketNumber%1000/100 + ticketNumber%10;

            if (firstTicketPart - secondTicketPart == 0)
            {
                Console.WriteLine("Билет является счастливым!");
            }
            else if (Math.Abs(firstTicketPart - secondTicketPart) == 1)
            {
                Console.WriteLine("Билет является почти счастливым!");
            }
            else
                Console.WriteLine("Билет не счастливый!");
            Console.ReadKey();
        }
    }
}