using System;
using OpenClosedPrinciple_Museum_Strategy_End.Logic;
using OpenClosedPrinciple_Museum_Strategy_End.Logic.Strategies;

namespace OpenClosedPrinciple_Museum_Strategy_End
{
    class Program
    {
        static void Main(string[] args)
        {
            Museum museum = new Museum(5);

            museum.Visit(new Person("Mehmet Sultanul", 4, new ChildTicketStrategy()));
            museum.Visit(new Person("Cristina Pop", 6, new ChildTicketStrategy()));
            museum.Visit(new Person("Rafael Popescu", 20, new AdultTicketStrategy()));
            museum.Visit(new Person("Nadia Comanici", 33, new AdultTicketStrategy()));
            museum.Visit(new Person("Mihai Lungu", 83, new SeniorTicketStrategy()));

            Console.WriteLine($"The museum's income from tickets: {museum.IncomeFromTickets}");
        }
    }
}
