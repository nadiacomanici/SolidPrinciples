using System;
using SingleResponsability_Orders_End.Logic.Exceptions;

namespace SingleResponsability_Orders_End.Logic.Implementations
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
