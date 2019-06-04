using DependencyInjection_Orders_Begin.Logic.Carts;
using DependencyInjection_Orders_Begin.Logic.Implementations;

namespace DependencyInjection_Orders_Begin.Logic.Orders
{
    public class POSCashOrder : Order
    {
        private readonly ReservationService reservationService;

        public POSCashOrder(Cart cart, Customer customer)
            : base(cart, customer)
        {
            reservationService = new ReservationService();
        }

        public override void Checkout()
        {
            reservationService.ReserveInventory(cart);
        }
    }
}
