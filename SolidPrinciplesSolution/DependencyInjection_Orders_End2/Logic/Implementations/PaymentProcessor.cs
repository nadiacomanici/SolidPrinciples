using System;
using DependencyInjection_Orders_End.Logic.Carts;
using DependencyInjection_Orders_End.Logic.Contracts;
using DependencyInjection_Orders_End.Logic.Exceptions;

namespace DependencyInjection_Orders_End.Logic.Implementations
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
