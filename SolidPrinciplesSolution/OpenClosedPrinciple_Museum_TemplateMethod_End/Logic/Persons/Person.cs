namespace OpenClosedPrinciple_Museum_TemplateMethod_End.Logic.Persons
{
    public abstract class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public abstract double TicketPriceMultiplier { get; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
