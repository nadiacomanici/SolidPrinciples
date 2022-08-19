using System.Collections.Generic;
using System.Linq;
using DependencyInversion_Orders_Demo.Logic.Carts;
using DependencyInversion_Orders_Demo.Logic.Exceptions;

namespace DependencyInversion_Orders_Demo.Logic.Inventories
{
    public class InventorySystem
    {
        private int _nextId;

        public List<InventoryItem> Items { get; private set; }

        public InventorySystem()
        {
            Items = new List<InventoryItem>();
            _nextId = 1;

            this.AddToStock("Alice in wonderland", 10, 12.5);
            this.AddToStock("Wizard of Oz", 10, 20);
            this.AddToStock("Ion", 3, 10);
            this.AddToStock("The 5 love languages", 5, 21.99);
            this.AddToStock("C# for dummies", 8, 11.99);
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
