namespace OpenClosedPrinciple_Museum_Strategy_Penta.Logic
{
    public class Child : Person
    {
        public Child(string name, int age)
            : base(name, age)
        {

        }

        public override double TicketPriceMultiplier { get { return 0; } }
    }
}
