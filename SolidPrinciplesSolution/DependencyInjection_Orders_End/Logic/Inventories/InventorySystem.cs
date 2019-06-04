using System.Collections.Generic;
using System.Linq;
using DependencyInjection_Orders_End.Logic.Carts;
using DependencyInjection_Orders_End.Logic.Exceptions;

namespace DependencyInjection_Orders_End.Logic.Inventories
{
    public class InventorySystem
    {
        private int _nextId;

        public List<InventoryItem> Items { get; private set; }

        public InventorySystem()
        {
            Items = new List<InventoryItem>();
            _nextId = 1;
        }

        public void AddToStock(string name, int quantity, double price)
        {
            Items.Add(new InventoryItem(_nextId++, name, quantity, price));
        }

        public CartItem Reserve(int itemId, int orderedQuantity)
        {
            var itemInInventory = Items.SingleOrDefault(i => i.Id == itemId);
            if (itemInInventory == null)
            {
                throw new OrderException("Invalid item id");
            }

            if (itemInInventory.AvailableQuantity >= orderedQuantity)
            {
                itemInInventory.AvailableQuantity -= orderedQuantity;
                return new CartItem(itemInInventory.Id, orderedQuantity, itemInInventory.Price, itemInInventory.Name);
            }
            else
            {
                throw new InsufficientInventoryException();
            }
        }
    }
}
