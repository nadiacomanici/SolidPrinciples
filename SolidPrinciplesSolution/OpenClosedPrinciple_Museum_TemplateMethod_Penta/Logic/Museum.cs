using System.Collections.Generic;

namespace OpenClosedPrinciple_Museum_TemplateMethod_Penta.Logic
{
    public class Museum
    {
        private readonly double _fullTicketPrice;
        private List<Person> _visitors;

        public double IncomeFromTickets { get; private set; }

        public Museum(double fullTicketPrice)
        {
            _visitors = new List<Person>();
            IncomeFromTickets = 0;
            _fullTicketPrice = fullTicketPrice;
        }

        public void Visit(Person person)
        {
            _visitors.Add(person);
            IncomeFromTickets += _fullTicketPrice * person.TicketStrategy.TicketPriceMultiplier;
        }
    }
}
