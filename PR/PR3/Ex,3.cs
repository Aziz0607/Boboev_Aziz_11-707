using System;

namespace ConsoleApp
{
    class IsTicketHappines
    {
        public static void Main(string[] args)
        {
            int
                ticketNumber = Convert.ToInt32(Console.ReadLine()),
                firstTicketPart = ticketNumber / 100000 + ticketNumber / 10000 % 10 + ticketNumber / 1000 % 100 % 10,
                secondTicketPartDecrement = (ticketNumber - 1) / 100 % 1000 % 100 % 10 + (ticketNumber - 1) / 10 % 10000 % 1000 % 100 % 10 + (ticketNumber - 1) % 100000 % 10000 % 1000 % 100 % 10,
                secondTicketPartIncrement = (ticketNumber + 1) / 100 % 1000 % 100 % 10 + (ticketNumber + 1) / 10 % 10000 % 1000 % 100 % 10 + (ticketNumber + 1) % 100000 % 10000 % 1000 % 100 % 10;

            Console.WriteLine("Предыдущий билет является: {0}", (firstTicketPart == secondTicketPartDecrement) ? "Счастливым" : "Не счастивым");
            Console.WriteLine("Следующий билет является: {0}", (firstTicketPart == secondTicketPartIncrement) ? "Счастливым" : "Не счастливым");

            Console.ReadKey();
        }
    }
}