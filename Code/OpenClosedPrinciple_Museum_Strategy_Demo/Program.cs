using System;
using OpenClosedPrinciple_Museum_Strategy_Demo.Logic;

namespace OpenClosedPrinciple_Museum_Strategy_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Museum museum = new Museum();

            museum.Visit(new Infant("Mehmet Sultanul", 4));
            museum.Visit(new Infant("Cristina Pop", 6));
            museum.Visit(new Adolescent("Matei Ionescu", 14));
            museum.Visit(new Adult("Rafael Popescu", 20));
            museum.Visit(new Adult("Nadia Comanici", 33));
            museum.Visit(new Senior("Mihai Lungu", 83));

            Console.WriteLine($"The museum's income from tickets: {museum.IncomeFromTickets}");
        }
    }
}
