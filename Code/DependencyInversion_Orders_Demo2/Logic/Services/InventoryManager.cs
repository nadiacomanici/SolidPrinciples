using System;
using System.Collections.Generic;
using SingleResponsability_Orders_Demo.Logic.Exceptions;

namespace SingleResponsability_Orders_Demo.Logic.Services
{
    public class InventoryManager : IInventoryManager
    {
        private readonly IInventorySystem inventorySystem;

        public InventoryManager(IInventorySystem inventorySystem)
        {
            this.inventorySystem = inventorySystem;
        }

        public void ReserveInventory(List<CartItem> items)
        {
            Console.WriteLine("ReserveInventory");

            foreach (var item in items)
            {
                try
                {
                    inventorySystem.Reserve(item.Id, item.Quantity);
                }
                catch (InsufficientInventoryException)
                {
                    throw new OrderException($"Insufficient available items for {item.Id}");
                }
                catch (Exception)
                {
                    throw new OrderException($"Problems reserving {item.Id}");
                }
            }
        }
    }
}
