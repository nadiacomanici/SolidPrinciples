namespace OpenClosedPrinciple_Museum_Strategy_Demo.Logic
{
    public class Senior : Person
    {
        public Senior(string name, int age) : base(name, age)
        {
        }

        public override double GetTicketMultiplier()
        {
            return 0.5;
        }
    }


}
