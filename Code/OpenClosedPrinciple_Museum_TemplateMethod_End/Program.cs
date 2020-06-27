using System;
using OpenClosedPrinciple_Museum_TemplateMethod_End.Logic;
using OpenClosedPrinciple_Museum_TemplateMethod_End.Logic.Persons;

namespace OpenClosedPrinciple_Museum_TemplateMethod_End
{
    class Program
    {
        static void Main(string[] args)
        {
            Museum museum = new Museum(5);

            museum.Visit(new Child("Mehmet Sultanul", 4));
            museum.Visit(new Child("Cristina Pop", 6));
            museum.Visit(new Adult("Rafael Popescu", 20));
            museum.Visit(new Adult("Nadia Comanici", 33));
            museum.Visit(new Senior("Mihai Lungu", 83));

            Console.WriteLine($"The museum's income from tickets: {museum.IncomeFromTickets}");
        }
    }
}
