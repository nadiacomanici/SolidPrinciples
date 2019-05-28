namespace SingleResponsability_Orders_Penta.Logic.Orders
{
    public class CreditCardOrder : Order
    {
        private readonly PaymentDetails _paymentDetails;

        private InventoryManager _inventoryManager;
        private PaymentService _paymentService;

        public CreditCardOrder(Cart cart, Customer customer, PaymentDetails paymentDetails) : base(cart, customer)
        {
            _paymentDetails = paymentDetails;

            _inventoryManager = new InventoryManager();
            _paymentService = new PaymentService();
        }
        public override void Checkout()
        {
            _paymentService.ChargeCard(_paymentDetails);
            _inventoryManager.ReserveInventory(cart);
        }
    }
}
