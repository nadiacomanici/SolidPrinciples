using System;
using DependencyInjection_Orders_End.Logic.Carts;
using DependencyInjection_Orders_End.Logic.Contracts;
using DependencyInjection_Orders_End.Logic.Exceptions;
using DependencyInjection_Orders_End.Logic.Inventories;

namespace DependencyInjection_Orders_End.Logic.Orders
{
    public abstract class Order
    {
        protected Cart cart;
        protected Customer customer;

        protected IReservationService reservationService;

        public Order(Cart cart, Customer customer)
        {
            this.cart = cart;
            this.customer = customer;
        }

        public virtual void Checkout()
        {
            ReserveInventory();
        }

        private void ReserveInventory()
        {
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
