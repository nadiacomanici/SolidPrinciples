namespace OpenClosedPrinciple_Museum_TemplateMethod_Demo.Logic
{
    public class SeniorTicketStrategy : TicketStrategy
    {
        public override double GetTicketMultiplier()
        {
            return 0.5;
        }
    }

}