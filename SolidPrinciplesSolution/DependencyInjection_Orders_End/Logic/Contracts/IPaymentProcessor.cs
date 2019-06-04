using DependencyInjection_Orders_End.Logic.Carts;

namespace DependencyInjection_Orders_End.Logic.Contracts
{
    public interface IPaymentProcessor
    {
        void ProcessCreditCard(CreditCard creditCard, Cart cart);
    }
}
