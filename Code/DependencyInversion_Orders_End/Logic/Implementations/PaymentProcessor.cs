using System;
using DependencyInversion_Orders_End.Logic.Carts;
using DependencyInversion_Orders_End.Logic.Exceptions;
using DependencyInversion_Orders_End.Logic.Contracts;

namespace DependencyInversion_Orders_End.Logic.Implementations
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
