using DependencyInjection_Orders_Penta.Logic.Carts;

namespace DependencyInjection_Orders_Penta.Logic.Implementations
{
    public interface IReservationService
    {
        void ReserveInventory(Cart cart);
    }
}