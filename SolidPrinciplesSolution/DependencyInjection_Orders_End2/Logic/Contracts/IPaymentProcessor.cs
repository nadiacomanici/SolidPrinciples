using DependencyInjection_Orders_End.Logic.Carts;

namespace DependencyInjection_Orders_End.Logic.Contracts
{
    interface IPaymentProcessor
    {
        void ProcessCreditCard(CreditCard creditCard, Cart cart);
    }
}
