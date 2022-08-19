using DependencyInversion_Orders_End.Logic.Carts;

namespace DependencyInversion_Orders_End.Logic.Contracts
{
    public interface IPaymentProcessor
    {
        void ProcessCreditCard(CreditCard creditCard, Cart cart);
    }
}
