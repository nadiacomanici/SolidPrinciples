namespace OpenClosedPrinciple_Museum_TemplateMethod_Demo.Logic
{
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public TicketStrategy TicketStrategy { get; private set; }

        public Person(string name, int age, TicketStrategy ticketStrategy)
        {
            Name = name;
            Age = age;
            TicketStrategy = ticketStrategy;
        }
    }
}
