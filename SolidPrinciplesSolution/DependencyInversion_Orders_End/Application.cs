using System;
using DependencyInversion_Orders_End.Logic;
using DependencyInversion_Orders_End.Logic.Carts;
using DependencyInversion_Orders_End.Logic.Contracts;
using DependencyInversion_Orders_End.Logic.Inventories;
using DependencyInversion_Orders_End.Logic.Orders;

namespace DependencyInversion_Orders_End
{
    public class Application
    {
        private readonly INotificationService notificationService;
        private readonly IPaymentProcessor paymentProcessor;
        private readonly IReservationService reservationService;
        private readonly InventorySystem inventorySystem;

        public Application(INotificationService notificationService, IPaymentProcessor paymentProcessor,
            IReservationService reservationService, InventorySystem inventorySystem)
        {
            this.notificationService = notificationService;
            this.paymentProcessor = paymentProcessor;
            this.reservationService = reservationService;
            this.inventorySystem = inventorySystem;
        }

        public void Run()
        {
            inventorySystem.AddToStock("Alice in wonderland", 10, 12.5);
            inventorySystem.AddToStock("Wizard of Oz", 10, 20);
            inventorySystem.AddToStock("Ion", 3, 10);
            inventorySystem.AddToStock("The 5 love languages", 5, 21.99);
            inventorySystem.AddToStock("C# for dummies", 8, 11.99);

            var cart = new Cart();
            cart.Items.Add(new CartItem(1, 1, 12.5, "Alice in wonderland"));
            cart.Items.Add(new CartItem(2, 2, 20, "Wizard of Oz"));
            cart.Items.Add(new CartItem(4, 1, 21.99, "The 5 love languages"));
            cart.Items.Add(new CartItem(5, 1, 11.99, "C# for dummies"));

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
            Console.WriteLine($"Remaining money on card: {creditCardPaymentDetails.Money}");
            Console.WriteLine();

            // POS Credit Card
            Console.WriteLine("2. POS Credit Card order:");
            var posCreditOrder = new POSCreditOrder(cart, customer, creditCardPaymentDetails, paymentProcessor, reservationService);
            posCreditOrder.Checkout();
            Console.WriteLine($"Remaining money on card: {creditCardPaymentDetails.Money}");
            Console.WriteLine();

            // POS Cash
            Console.WriteLine("3. POS Cash order:");
            var posCashOrder = new POSCashOrder(cart, customer, reservationService);
            posCashOrder.Checkout();
            Console.WriteLine($"Remaining money on card: {creditCardPaymentDetails.Money}");
            Console.WriteLine();
        }
    }
}
