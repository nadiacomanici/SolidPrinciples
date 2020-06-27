using SingleResponsability_Orders_Demo.Logic.Services;

namespace SingleResponsability_Orders_Demo.Logic.Orders
{
    public class CashOrder : Order
    {
        private InventoryManager inventoryManager;

        public CashOrder(Cart cart, Customer customer,
            InventoryManager inventoryManager) : base(cart, customer)
        {
            this.inventoryManager = inventoryManager;
        }

        public override void Checkout()
        {
            inventoryManager.ReserveInventory(cart.Items);
        }
    }
}
