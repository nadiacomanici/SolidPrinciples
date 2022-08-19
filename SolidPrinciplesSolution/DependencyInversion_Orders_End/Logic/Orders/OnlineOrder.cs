using DependencyInversion_Orders_End.Logic.Carts;
using DependencyInversion_Orders_End.Logic.Contracts;

namespace DependencyInversion_Orders_End.Logic.Orders
{
    public class OnlineOrder : Order
    {
        private readonly CreditCard _creditCard;
        private readonly INotificationService _notificationService;
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly IReservationService _reservationService;

        public OnlineOrder(Cart cart, Customer customer, CreditCard paymentDetails,
            INotificationService notificationService, IPaymentProcessor paymentProcessor, IReservationService reservationService)
            : base(cart, customer)
        {
            _creditCard = paymentDetails;
            _notificationService = notificationService;
            _paymentProcessor = paymentProcessor;
            _reservationService = reservationService;
        }

        public override void Checkout()
        {
            _paymentProcessor.ProcessCreditCard(_creditCard, _cart);
            _reservationService.ReserveInventory(_cart);
            _notificationService.NotifyCustomer(_cart, _customer);
        }
    }
}
