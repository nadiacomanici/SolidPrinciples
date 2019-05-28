namespace SingleResponsability_Orders_Penta.Logic.Orders
{
    public class CashOrder : Order
    {
        private InventoryManager _inventoryManager;

        public CashOrder(Cart cart, Customer customer) : base(cart, customer)
        {
            _inventoryManager = new InventoryManager();
        }
        public override void Checkout()
        {
            _inventoryManager.ReserveInventory(cart);
        }
    }
}
