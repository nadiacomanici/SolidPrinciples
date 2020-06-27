using SingleResponsability_Orders_Demo.Logic.Services;

namespace SingleResponsability_Orders_Demo.Logic.Orders
{
    public class OnlineOrder : Order
    {
        private CardPaymentService cardPaymentService;
        private InventoryManager inventoryManager;
        private EmailNotificationService emailService;
        private CardPaymentDetails paymentDetails;

        public OnlineOrder(Cart cart, Customer customer, CardPaymentDetails paymentDetails,
            CardPaymentService cardPaymentService, InventoryManager inventoryManager, EmailNotificationService emailService) : base(cart, customer)
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
