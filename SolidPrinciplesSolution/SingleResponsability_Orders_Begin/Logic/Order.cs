using System;
using SingleResponsability_Orders_Begin.Logic.Exceptions;

namespace SingleResponsability_Orders_Begin.Logic
{
    public class Order
    {
        private Cart cart;
        private Customer customer;

        public Order(Cart cart, Customer customer)
        {
            this.cart = cart;
            this.customer = customer;
        }

        private void ChargeCard(PaymentDetails paymentDetails)
        {
            // Get sum of money from the credit card
            Console.WriteLine("ChargeCard");
        }

        public void Checkout(PaymentDetails paymentDetails, bool notifyCustomer)
        {
            if (paymentDetails.PaymentMethod == PaymentMethod.CreditCard)
            {
                ChargeCard(paymentDetails);
            }

            ReserveInventory();

            if (notifyCustomer)
            {
                NotifyCustomer();
            }
        }

        private void NotifyCustomer()
        {
            Console.WriteLine("NotifyCustomer");
            if (!string.IsNullOrEmpty(customer.Email))
            {
                // send email
            }
        }

        private void ReserveInventory()
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
