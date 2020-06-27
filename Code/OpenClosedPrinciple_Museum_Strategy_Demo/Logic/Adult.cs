namespace OpenClosedPrinciple_Museum_Strategy_Demo.Logic
{
    public class Adult : Person
    {
        public Adult(string name, int age) : base(name, age)
        {
        }

        public override double GetTicketMultiplier()
        {
            return 1;
        }
    }


}
