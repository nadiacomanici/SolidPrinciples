using DependencyInjection_Orders_End.Logic.Carts;
using DependencyInjection_Orders_End.Logic.Contracts;
using DependencyInjection_Orders_End.Logic.Implementations;

namespace DependencyInjection_Orders_End.Logic.Orders
{
    public class OnlineOrder : Order
    {
        private readonly CreditCard paymentDetails;
        private readonly INotificationService notificationService;
        private readonly IPaymentProcessor paymentProcessor;

        public OnlineOrder(Cart cart, Customer customer, CreditCard paymentDetails)
            : base(cart, customer)
        {
            this.paymentDetails = paymentDetails;
            this.notificationService = new NotificationService();
            this.reservationService = new ReservationService();
            this.paymentProcessor = new PaymentProcessor();
        }

        public override void Checkout()
        {
            paymentProcessor.ProcessCreditCard(paymentDetails, cart);
            base.Checkout();
            notificationService.NotifyCustomer(cart, customer);
        }
    }
}
