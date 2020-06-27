using SingleResponsability_Orders_Demo.Logic.Services;

namespace SingleResponsability_Orders_Demo.Logic.Orders
{
    public class POSOrder : Order
    {
        private CardPaymentService cardPaymentService;
        private InventoryManager inventoryManager;
        private CardPaymentDetails paymentDetails;

        public POSOrder(Cart cart, Customer customer, CardPaymentDetails paymentDetails,
            CardPaymentService cardPaymentService, InventoryManager inventoryManager) : base(cart, customer)
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
