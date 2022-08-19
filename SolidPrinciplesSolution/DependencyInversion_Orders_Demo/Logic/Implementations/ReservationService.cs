using System;
using DependencyInversion_Orders_Demo.Logic.Carts;
using DependencyInversion_Orders_Demo.Logic.Exceptions;
using DependencyInversion_Orders_Demo.Logic.Inventories;

namespace DependencyInversion_Orders_Demo.Logic.Implementations
{
    public class ReservationService
    {
        private readonly InventorySystem _inventorySystem;

        public ReservationService()
        {
            _inventorySystem = new InventorySystem();
        }

        public void ReserveInventory(Cart cart)
        {
            foreach (var item in cart.Items)
            {
                try
                {
                    _inventorySystem.Reserve(item.Id, item.Quantity);
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
