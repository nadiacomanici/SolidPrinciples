using System;
using DependencyInversion_Orders_Demo.Logic.Carts;
using DependencyInversion_Orders_Demo.Logic.Exceptions;

namespace DependencyInversion_Orders_Demo.Logic.Implementations
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
