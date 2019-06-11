using DependencyInjection_Orders_Penta.Logic.Carts;
using DependencyInjection_Orders_Penta.Logic.Implementations;

namespace DependencyInjection_Orders_Penta.Logic.Orders
{
    public class POSCreditOrder : Order
    {
        private readonly CreditCard paymentDetails;
        private readonly IPaymentProcessor paymentProcessor;
        private readonly IReservationService reservationService;

        public POSCreditOrder(IPaymentProcessor paymentProcessor,
            IReservationService reservationService, 
            Cart cart, 
            Customer customer, 
            CreditCard paymentDetails)
            : base(cart, customer)
        {
            this.paymentDetails = paymentDetails;
            this.reservationService = reservationService;
            this.paymentProcessor = paymentProcessor;
        }

        public override void Checkout()
        {
            paymentProcessor.ProcessCreditCard(paymentDetails, cart);
            reservationService.ReserveInventory(cart);
        }
    }
}
