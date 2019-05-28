using System;
using SingleResponsability_Orders_Penta.Logic.Exceptions;

namespace SingleResponsability_Orders_Penta.Logic
{
    public class InventoryManager
    {
        public void ReserveInventory(Cart cart)
        {
            Console.WriteLine("ReserveInventory");
            var inventorySystem = new InventorySystem();
            foreach (var item in cart.Items)
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
