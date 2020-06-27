namespace OpenClosedPrinciple_Museum_Strategy_Demo.Logic
{
    public class Infant : Person
    {
        public Infant(string name, int age):base(name, age)
        {

        }

        public override double GetTicketMultiplier()
        {
            return 0;
        }
    }


}
