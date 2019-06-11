using DependencyInjection_Orders_Penta.Logic.Carts;
using DependencyInjection_Orders_Penta.Logic.Implementations;

namespace DependencyInjection_Orders_Penta.Logic.Orders
{
    public class OnlineOrder : Order
    {
        private readonly CreditCard paymentDetails;
        private readonly IPaymentProcessor paymentProcessor;
        private readonly INotificationService notificationService;
        private readonly IReservationService reservationService;

        public OnlineOrder(INotificationService notificationService,
            IPaymentProcessor paymentProcessor,
            IReservationService reservationService,
            Cart cart, 
            Customer customer, 
            CreditCard paymentDetails)
            : base(cart, customer)
        {
            this.paymentDetails = paymentDetails;
            this.notificationService = notificationService;
            this.reservationService = reservationService;
            this.paymentProcessor = paymentProcessor;
        }

        public override void Checkout()
        {
            paymentProcessor.ProcessCreditCard(paymentDetails, cart);
            reservationService.ReserveInventory(cart);
            notificationService.NotifyCustomer(cart, customer);
        }
    }
}
