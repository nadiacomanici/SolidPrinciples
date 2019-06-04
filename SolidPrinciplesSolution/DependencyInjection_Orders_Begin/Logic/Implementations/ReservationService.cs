using System;
using DependencyInjection_Orders_Begin.Logic.Carts;
using DependencyInjection_Orders_Begin.Logic.Exceptions;
using DependencyInjection_Orders_Begin.Logic.Inventories;

namespace DependencyInjection_Orders_Begin.Logic.Implementations
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
