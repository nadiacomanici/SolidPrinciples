namespace OpenClosedPrinciple_Museum_TemplateMethod_End.Logic.Persons
{
    public class Child : Person
    {
        public Child(string name, int age) : base(name, age)
        {
        }

        public override double TicketPriceMultiplier
        {
            get { return 0.0; }
        }
    }
}
