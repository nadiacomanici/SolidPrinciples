using System;
using SingleResponsability_Orders_Demo.Logic;
using SingleResponsability_Orders_Demo.Logic.Orders;
using SingleResponsability_Orders_Demo.Logic.Services;

namespace SingleResponsability_Orders_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var cart = new Cart();
            cart.Items.Add(new CartItem(24, 1));
            cart.Items.Add(new CartItem(101, 2));
            cart.Items.Add(new CartItem(44, 1));
            cart.Items.Add(new CartItem(82, 1));
            cart.Items.Add(new CartItem(75, 3));

            var customer = new Customer("Nadia", "Comanici", "nadia@email.com");

            var paymentCreditCard = new CardPaymentDetails()
            {
                CardNumber = "ABCD 1234 ABCD 1234 ABCD 1234",
                CardholderName = "Nadia C",
                ExpiresMonth = 1,
                ExpiresYear = 2020
            };

            var cardPaymentService = new CardPaymentService();
            var inventoryManager = new InventoryManager();
            var emailService = new EmailNotificationService();

            // WebSite
            Console.WriteLine("1. Website order:");
            var onlineOrder = new OnlineOrder(cart, customer, paymentCreditCard, cardPaymentService, inventoryManager, emailService);
            onlineOrder.Checkout();
            Console.WriteLine();

            // POS Credit Card
            Console.WriteLine("2. POS Credit Card order:");
            var posOrder = new POSOrder(cart, customer, paymentCreditCard, cardPaymentService, inventoryManager);
            posOrder.Checkout();
            Console.WriteLine();

            // POS Cash
            Console.WriteLine("3. Cash order:");
            var cashOrder = new CashOrder(cart, customer, inventoryManager);
            cashOrder.Checkout();
            Console.WriteLine();
        }
    }
}
