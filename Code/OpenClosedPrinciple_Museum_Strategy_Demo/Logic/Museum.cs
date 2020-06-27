using System.Collections.Generic;

namespace OpenClosedPrinciple_Museum_Strategy_Demo.Logic
{
    public class Museum
    {
        private const double _fullTicketPrice = 5;
        private List<Person> _visitors;

        public double IncomeFromTickets { get; private set; }

        public Museum()
        {
            _visitors = new List<Person>();
            IncomeFromTickets = 0;
        }

        public void Visit(Person person)
        {
            _visitors.Add(person);

            // All children under 7 years have free entry
            // All senior citizens (> 65 years) have 50% reduced ticket
            double ticketPrice = _fullTicketPrice * person.GetTicketMultiplier();
            IncomeFromTickets += ticketPrice;
        }
    }
}
