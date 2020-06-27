using SingleResponsability_Orders_Demo.Logic.Services;

namespace SingleResponsability_Orders_Demo.Logic.Orders
{
    public class CashOrder : Order
    {
        private IInventoryManager inventoryManager;

        public CashOrder(Cart cart, Customer customer,
            IInventoryManager inventoryManager) : base(cart, customer)
        {
            this.inventoryManager = inventoryManager;
        }

        public override void Checkout()
        {
            inventoryManager.ReserveInventory(cart.Items);
        }
    }
}
