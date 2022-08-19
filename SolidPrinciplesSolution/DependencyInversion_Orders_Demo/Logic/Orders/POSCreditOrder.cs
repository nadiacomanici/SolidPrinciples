using DependencyInversion_Orders_Demo.Logic.Carts;
using DependencyInversion_Orders_Demo.Logic.Implementations;

namespace DependencyInversion_Orders_Demo.Logic.Orders
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
