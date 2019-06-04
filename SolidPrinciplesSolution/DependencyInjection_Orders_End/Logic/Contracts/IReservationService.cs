using DependencyInjection_Orders_End.Logic.Carts;

namespace DependencyInjection_Orders_End.Logic.Contracts
{
    public interface IReservationService
    {
        void ReserveInventory(Cart cart);
    }
}
