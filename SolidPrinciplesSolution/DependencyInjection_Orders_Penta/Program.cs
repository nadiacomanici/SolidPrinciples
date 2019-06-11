using System;
using DependencyInjection_Orders_Penta.Logic;
using DependencyInjection_Orders_Penta.Logic.Carts;
using DependencyInjection_Orders_Penta.Logic.Implementations;
using DependencyInjection_Orders_Penta.Logic.Orders;
using Autofac;

namespace DependencyInjection_Orders_Penta
{
    class Program
    {
        static void Main(string[] args)
        {
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

            var container = DependencyInjection.Container;
            using (var scope = container.BeginLifetimeScope())
            {
                var notificationService = scope.Resolve<INotificationService>();
                var paymentProcessor = scope.Resolve<IPaymentProcessor>();
                var reservationService = scope.Resolve<IReservationService>();

                // WebSite
                Console.WriteLine("1. Website order:");
                
                var onlineOrder = new OnlineOrder(notificationService, paymentProcessor, reservationService, cart, customer, creditCardPaymentDetails);
                onlineOrder.Checkout();
                Console.WriteLine($"Remainng money: {creditCardPaymentDetails.Money}");
                Console.WriteLine();
                 
                // POS Credit Card
                Console.WriteLine("2. POS Credit Card order:");
                var posCreditOrder = new POSCreditOrder(paymentProcessor, reservationService, cart, customer, creditCardPaymentDetails);
                posCreditOrder.Checkout();
                Console.WriteLine($"Remainng money: {creditCardPaymentDetails.Money}");
                Console.WriteLine();

                // POS Cash
                Console.WriteLine("3. POS Cash order:");
                var posCashOrder = new POSCashOrder(reservationService, cart, customer);
                posCashOrder.Checkout();
                Console.WriteLine($"Remainng money: {creditCardPaymentDetails.Money}");
                Console.WriteLine();
            }
        }
    }
}
