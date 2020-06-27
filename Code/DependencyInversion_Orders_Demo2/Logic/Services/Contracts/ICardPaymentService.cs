namespace SingleResponsability_Orders_Demo.Logic.Services
{
    public interface ICardPaymentService
    {
        void ChargeCard(CardPaymentDetails paymentDetails);
    }
}