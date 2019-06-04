namespace DependencyInjection_Orders_End.Logic
{
    public class CreditCard
    {
        public string CardNumber { get; set; }
        public string CardholderName { get; set; }
        public int ExpiresMonth { get; set; }
        public int ExpiresYear { get; set; }
        public double Money { get; set; }
    }
}
