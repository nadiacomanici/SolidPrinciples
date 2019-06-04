using System;

namespace SingleResponsability_Orders_End.Logic.Implementations
{
    public class PaymentProcessor
    {
        public void ProcessCreditCard(CreditCard paymentDetails, Cart cart)
        {
            // Get sum of money from the credit card
            Console.WriteLine("ChargeCard");
        }
    }
}
