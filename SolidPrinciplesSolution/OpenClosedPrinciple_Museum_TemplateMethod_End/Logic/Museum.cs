using System.Collections.Generic;
using OpenClosedPrinciple_Museum_TemplateMethod_End.Logic.Persons;

namespace OpenClosedPrinciple_Museum_TemplateMethod_End.Logic
{
    public class Museum
    {
        private readonly double _fullTicketPrice;
        private List<Person> _visitors;

        public double IncomeFromTickets { get; private set; }

        public Museum(double fullTicketPrice)
        {
            _visitors = new List<Person>();
            _fullTicketPrice = fullTicketPrice;
            IncomeFromTickets = 0;
        }

        public void Visit(Person person)
        {
            _visitors.Add(person);
            IncomeFromTickets += _fullTicketPrice * person.TicketPriceMultiplier;
        }
    }
}
