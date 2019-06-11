using DependencyInjection_Orders_Penta.Logic.Carts;
using DependencyInjection_Orders_Penta.Logic.Implementations;

namespace DependencyInjection_Orders_Penta.Logic.Orders
{
    public class POSCashOrder : Order
    {
        private readonly IReservationService reservationService;

        public POSCashOrder(IReservationService reservationService, Cart cart, Customer customer)
            : base(cart, customer)
        {
            this.reservationService = reservationService;
        }

        public override void Checkout()
        {
            reservationService.ReserveInventory(cart);
        }
    }
}
