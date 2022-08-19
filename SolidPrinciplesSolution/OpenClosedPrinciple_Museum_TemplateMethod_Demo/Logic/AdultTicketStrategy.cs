namespace OpenClosedPrinciple_Museum_TemplateMethod_Demo.Logic
{
    public class AdultTicketStrategy : TicketStrategy
    {
        public override double GetTicketMultiplier()
        {
            return 1.0;
        }
    }

}