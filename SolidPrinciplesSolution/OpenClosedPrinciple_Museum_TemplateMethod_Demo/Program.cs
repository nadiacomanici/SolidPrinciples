using System;
using OpenClosedPrinciple_Museum_TemplateMethod_Demo.Logic;

namespace OpenClosedPrinciple_Museum_TemplateMethod_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Museum museum = new Museum();

            museum.Visit(new Person("Mehmet Sultanul", 4, new ChildTicketStrategy()));
            museum.Visit(new Person("Cristina Pop", 6, new ChildTicketStrategy()));
            museum.Visit(new Person("Matei Ionescu", 13, new AdolescentTicketStrategy()));
            museum.Visit(new Person("Rafael Popescu", 20, new AdultTicketStrategy()));
            museum.Visit(new Person("Nadia Comanici", 33, new AdultTicketStrategy()));
            museum.Visit(new Person("Mihai Lungu", 83, new SeniorTicketStrategy()));

            Console.WriteLine($"The museum's income from tickets: {museum.IncomeFromTickets}");
        }
    }
}
