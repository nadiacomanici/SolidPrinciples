using System;
using DependencyInjection_Orders_End.Logic.Carts;
using DependencyInjection_Orders_End.Logic.Exceptions;
using DependencyInjection_Orders_End.Logic.Inventories;
using DependencyInjection_Orders_End.Logic.Contracts;

namespace DependencyInjection_Orders_End.Logic.Implementations
{
    public class ReservationService : IReservationService
    {
        private readonly InventorySystem _inventorySystem;

        public ReservationService(InventorySystem inventorySystem)
        {
            _inventorySystem = inventorySystem;
        }

        public void ReserveInventory(Cart cart)
        {
            Console.WriteLine("ReserveInventory");
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
