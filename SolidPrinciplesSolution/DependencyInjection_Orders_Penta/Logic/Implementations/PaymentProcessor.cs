using System;
using DependencyInjection_Orders_Penta.Logic.Carts;
using DependencyInjection_Orders_Penta.Logic.Exceptions;

namespace DependencyInjection_Orders_Penta.Logic.Implementations
{
    public class PaymentProcessor : IPaymentProcessor
    {
        public void ProcessCreditCard(CreditCard creditCard, Cart cart)
        {
            var total = cart.TotalCost;
            if (creditCard.Money > total)
            {
                creditCard.Money -= total;
            }
            else
            {
                throw new OrderException("Insufficient funds");
            }
        }
    }
}
