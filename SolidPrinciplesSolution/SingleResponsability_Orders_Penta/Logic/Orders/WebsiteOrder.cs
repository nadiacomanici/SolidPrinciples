namespace SingleResponsability_Orders_Penta.Logic.Orders
{
    public class WebsiteOrder : Order
    {
        private readonly PaymentDetails _paymentDetails;

        private InventoryManager _inventoryManager;
        private PaymentService _paymentService;
        private EmailNotifier _emailNotifier;

        public WebsiteOrder(Cart cart, Customer customer, PaymentDetails paymentDetails) : base(cart, customer)
        {
            _paymentDetails = paymentDetails;

            _inventoryManager = new InventoryManager();
            _paymentService = new PaymentService();
            _emailNotifier = new EmailNotifier();
        }
        public override void Checkout()
        {
            _paymentService.ChargeCard(_paymentDetails);
            _inventoryManager.ReserveInventory(cart);
            _emailNotifier.NotifyCustomer(customer);
        }
    }
}
