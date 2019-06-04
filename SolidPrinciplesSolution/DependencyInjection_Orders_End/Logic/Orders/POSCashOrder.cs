using DependencyInjection_Orders_End.Logic.Carts;
using DependencyInjection_Orders_End.Logic.Contracts;
using DependencyInjection_Orders_End.Logic.Implementations;

namespace DependencyInjection_Orders_End.Logic.Orders
{
    public class POSCashOrder : Order
    {
        private readonly IReservationService _reservationService;

        public POSCashOrder(Cart cart, Customer customer, IReservationService reservationService)
            : base(cart, customer)
        {
            _reservationService = reservationService;
        }

        public override void Checkout()
        {
            _reservationService.ReserveInventory(_cart);
        }
    }
}
