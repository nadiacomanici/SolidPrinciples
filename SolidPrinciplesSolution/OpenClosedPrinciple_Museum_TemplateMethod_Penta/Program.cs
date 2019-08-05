using System;
using OpenClosedPrinciple_Museum_TemplateMethod_Penta.Logic;

namespace OpenClosedPrinciple_Museum_TemplateMethod_Penta
{
    class Program
    {
        static void Main(string[] args)
        {
            Museum museum = new Museum();

            museum.Visit(new Person("Mehmet Sultanul", 4));
            museum.Visit(new Person("Cristina Pop", 6));
            museum.Visit(new Person("Rafael Popescu", 20));
            museum.Visit(new Person("Nadia Comanici", 33));
            museum.Visit(new Person("Mihai Lungu", 83));

            Console.WriteLine($"The museum's income from tickets: {museum.IncomeFromTickets}");
        }
    }
}
