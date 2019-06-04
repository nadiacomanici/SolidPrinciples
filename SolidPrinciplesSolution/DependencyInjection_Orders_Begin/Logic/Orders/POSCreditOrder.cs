using DependencyInjection_Orders_Begin.Logic.Carts;
using DependencyInjection_Orders_Begin.Logic.Implementations;

namespace DependencyInjection_Orders_Begin.Logic.Orders
{
    public class POSCreditOrder : Order
    {
        private readonly CreditCard paymentDetails;
        private readonly PaymentProcessor paymentProcessor;
        private readonly ReservationService reservationService;

        public POSCreditOrder(Cart cart, Customer customer, CreditCard paymentDetails)
            : base(cart, customer)
        {
            this.paymentDetails = paymentDetails;
            this.reservationService = new ReservationService();
            this.paymentProcessor = new PaymentProcessor();
            this.reservationService = new ReservationService();
        }

        public override void Checkout()
        {
            paymentProcessor.ProcessCreditCard(paymentDetails, cart);
            reservationService.ReserveInventory(cart);
        }
    }
}
