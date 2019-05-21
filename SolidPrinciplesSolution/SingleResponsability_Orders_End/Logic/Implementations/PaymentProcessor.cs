using System;
using SingleResponsability_Orders_End.Logic.Contracts;

namespace SingleResponsability_Orders_End.Logic.Implementations
{
    public class PaymentProcessor : IPaymentProcessor
    {
        public void ProcessCreditCard(CreditCardPaymentDetails paymentDetails, Cart cart)
        {
            // Get sum of money from the credit card
            Console.WriteLine("ChargeCard");
        }
    }
}
