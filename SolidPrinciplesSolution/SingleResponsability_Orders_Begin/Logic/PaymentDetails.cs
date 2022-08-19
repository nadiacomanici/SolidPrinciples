namespace SingleResponsability_Orders_Begin.Logic
{
    public enum PaymentMethod
    {
        CreditCard,
        Cash
    }

    public class PaymentDetails
    {
        public string CardNumber { get; set; }
        public string CardholderName { get; set; }
        public int ExpiresMonth { get; set; }
        public int ExpiresYear { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
