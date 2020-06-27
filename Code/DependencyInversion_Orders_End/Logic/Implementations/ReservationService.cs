using System;
using DependencyInversion_Orders_End.Logic.Carts;
using DependencyInversion_Orders_End.Logic.Exceptions;
using DependencyInversion_Orders_End.Logic.Inventories;
using DependencyInversion_Orders_End.Logic.Contracts;
using Autofac;

namespace DependencyInversion_Orders_End.Logic.Implementations
{
    public class ReservationService : IReservationService
    {
        public InventorySystem InventorySystem { get; set; }

        public ReservationService()
        {
        }

        public void ReserveInventory(Cart cart)
        {
            Console.WriteLine("ReserveInventory");
            foreach (var item in cart.Items)
            {
                try
                {
                    InventorySystem.Reserve(item.Id, item.Quantity);
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
