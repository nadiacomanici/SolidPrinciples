using System;

namespace SingleResponsability_Orders_Demo.Logic.Services
{
    public class CardPaymentService
    {
        public void ChargeCard(CardPaymentDetails paymentDetails)
        {
            // Get sum of money from the credit card
            Console.WriteLine("ChargeCard");
        }
    }
}
