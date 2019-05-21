namespace SingleResponsability_Orders_End.Logic.Contracts
{
    interface IPaymentProcessor
    {
        void ProcessCreditCard(CreditCardPaymentDetails paymentDetails, Cart cart);
    }
}
