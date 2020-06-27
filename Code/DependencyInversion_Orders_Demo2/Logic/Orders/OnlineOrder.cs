using SingleResponsability_Orders_Demo.Logic.Services;

namespace SingleResponsability_Orders_Demo.Logic.Orders
{
    public class OnlineOrder : Order
    {
        private ICardPaymentService cardPaymentService;
        private IInventoryManager inventoryManager;
        private IEmailNotificationService emailService;
        private CardPaymentDetails paymentDetails;

        public OnlineOrder(Cart cart, Customer customer, CardPaymentDetails paymentDetails,
            ICardPaymentService cardPaymentService, IInventoryManager inventoryManager, IEmailNotificationService emailService) : base(cart, customer)
        {
            this.cardPaymentService = cardPaymentService;
            this.inventoryManager = inventoryManager;
            this.emailService = emailService;
            this.paymentDetails = paymentDetails;
        }

        public override void Checkout()
        {
            cardPaymentService.ChargeCard(paymentDetails);
            inventoryManager.ReserveInventory(cart.Items);
            emailService.NotifyCustomer();
        }
    }
}
