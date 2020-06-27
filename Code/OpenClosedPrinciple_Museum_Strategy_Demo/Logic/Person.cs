namespace OpenClosedPrinciple_Museum_Strategy_Demo.Logic
{
    public abstract class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract double GetTicketMultiplier();

    }
}
