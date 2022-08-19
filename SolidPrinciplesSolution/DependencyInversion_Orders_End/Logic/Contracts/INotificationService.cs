using DependencyInversion_Orders_End.Logic.Carts;

namespace DependencyInversion_Orders_End.Logic.Contracts
{
    public interface INotificationService
    {
        void NotifyCustomer(Cart cart, Customer customer);
    }
}
