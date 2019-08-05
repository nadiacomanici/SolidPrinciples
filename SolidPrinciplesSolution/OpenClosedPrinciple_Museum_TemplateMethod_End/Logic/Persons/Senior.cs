namespace OpenClosedPrinciple_Museum_TemplateMethod_End.Logic.Persons
{
    public class Senior : Person
    {
        public Senior(string name, int age) : base(name, age)
        {
        }

        public override double TicketPriceMultiplier
        {
            get { return 0.5; }
        }
    }
}
