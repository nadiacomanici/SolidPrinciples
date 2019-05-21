namespace SingleResponsability_Orders_End.Logic
{
    public class CreditCardPaymentDetails
    {
        public string CardNumber { get; set; }
        public string CardholderName { get; set; }
        public int ExpiresMonth { get; set; }
        public int ExpiresYear { get; set; }
    }
}
