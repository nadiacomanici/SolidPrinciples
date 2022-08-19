using DependencyInversion_Orders_End.Logic.Carts;

namespace DependencyInversion_Orders_End.Logic.Contracts
{
    public interface IReservationService
    {
        void ReserveInventory(Cart cart);
    }
}
