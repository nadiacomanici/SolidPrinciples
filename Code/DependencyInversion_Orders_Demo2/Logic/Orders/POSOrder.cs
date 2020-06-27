using SingleResponsability_Orders_Demo.Logic.Services;

namespace SingleResponsability_Orders_Demo.Logic.Orders
{
    public class POSOrder : Order
    {
        private ICardPaymentService cardPaymentService;
        private IInventoryManager inventoryManager;
        private CardPaymentDetails paymentDetails;

        public POSOrder(Cart cart, Customer customer, CardPaymentDetails paymentDetails,
            ICardPaymentService cardPaymentService, IInventoryManager inventoryManager) : base(cart, customer)
        {
            this.cardPaymentService = cardPaymentService;
            this.inventoryManager = inventoryManager;
            this.paymentDetails = paymentDetails;
        }

        public override void Checkout()
        {
            cardPaymentService.ChargeCard(paymentDetails);
            inventoryManager.ReserveInventory(cart.Items);
        }
    }
}
