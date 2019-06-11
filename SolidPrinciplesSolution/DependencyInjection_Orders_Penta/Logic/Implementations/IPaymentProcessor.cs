using DependencyInjection_Orders_Penta.Logic.Carts;

namespace DependencyInjection_Orders_Penta.Logic.Implementations
{
    public interface IPaymentProcessor
    {
        void ProcessCreditCard(CreditCard creditCard, Cart cart);
    }
}