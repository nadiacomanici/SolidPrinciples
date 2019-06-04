using System;
using DependencyInjection_Orders_Begin.Logic.Carts;
using DependencyInjection_Orders_Begin.Logic.Exceptions;

namespace DependencyInjection_Orders_Begin.Logic.Implementations
{
    public class PaymentProcessor
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
