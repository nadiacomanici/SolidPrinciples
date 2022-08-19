using DependencyInversion_Orders_Demo.Logic.Carts;
using DependencyInversion_Orders_Demo.Logic.Implementations;

namespace DependencyInversion_Orders_Demo.Logic.Orders
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
