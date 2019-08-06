namespace OpenClosedPrinciple_Museum_Strategy_Penta.Logic
{
    public class Adult : Person
    {
        public Adult(string name, int age)
            : base(name, age)
        {

        }

        public override double TicketPriceMultiplier { get { return 1; } }
    }
}
