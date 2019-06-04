using System;
using DependencyInjection_Orders_End.Logic;
using DependencyInjection_Orders_End.Logic.Carts;
using DependencyInjection_Orders_End.Logic.Implementations;
using DependencyInjection_Orders_End.Logic.Inventories;
using DependencyInjection_Orders_End.Logic.Orders;

namespace DependencyInjection_Orders_End
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventory = new InventorySystem();
            inventory.AddToStock("Alice in wonderland", 10, 12.5);
            inventory.AddToStock("Wizard of Oz", 10, 20);
            inventory.AddToStock("Ion", 3, 10);
            inventory.AddToStock("The 5 love languages", 5, 21.99);
            inventory.AddToStock("C# for dummies", 8, 11.99);

            var notificationService = new NotificationService();
            var paymentProcessor = new PaymentProcessor();
            var reservationService = new ReservationService(inventory);

            var cart = new Cart();
            cart.Items.Add(new CartItem(1, 1, 12.5, "Alice in wonderland"));
            cart.Items.Add(new CartItem(2, 2, 20, "Wizard of Oz"));
            cart.Items.Add(new CartItem(4, 1, 21.99, "The 5 love languages"));
            cart.Items.Add(new CartItem(5, 3, 11.99, "C# for dummies"));

            var customer = new Customer("Nadia", "Comanici", "nadia@email.com");

            var creditCardPaymentDetails = new CreditCard()
            {
                CardNumber = "ABCD 1234 ABCD 1234 ABCD 1234",
                CardholderName = "Nadia C",
                ExpiresMonth = 1,
                ExpiresYear = 2020,
                Money = 1000
            };

            // WebSite
            Console.WriteLine("1. Website order:");
            var onlineOrder = new OnlineOrder(cart, customer, creditCardPaymentDetails, notificationService, paymentProcessor, reservationService);
            onlineOrder.Checkout();
            Console.WriteLine($"Remainng money: {creditCardPaymentDetails.Money}");
            Console.WriteLine();

            // POS Credit Card
            Console.WriteLine("2. POS Credit Card order:");
            var posCreditOrder = new POSCreditOrder(cart, customer, creditCardPaymentDetails, paymentProcessor, reservationService);
            posCreditOrder.Checkout();
            Console.WriteLine($"Remainng money: {creditCardPaymentDetails.Money}");
            Console.WriteLine();

            // POS Cash
            Console.WriteLine("3. POS Cash order:");
            var posCashOrder = new POSCashOrder(cart, customer, reservationService);
            posCashOrder.Checkout();
            Console.WriteLine($"Remainng money: {creditCardPaymentDetails.Money}");
            Console.WriteLine();
        }
    }
}
