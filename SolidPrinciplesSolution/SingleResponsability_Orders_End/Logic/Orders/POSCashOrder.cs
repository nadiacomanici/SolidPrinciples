using SingleResponsability_Orders_End.Logic.Implementations;

namespace SingleResponsability_Orders_End.Logic.Orders
{
    public class POSCashOrder : Order
    {
        private readonly ReservationService _reservationService;

        public POSCashOrder(Cart cart, Customer customer)
            : base(cart, customer)
        {
            _reservationService = new ReservationService();
        }

        public override void Checkout()
        {
            _reservationService.ReserveInventory(_cart);
        }
    }
}
