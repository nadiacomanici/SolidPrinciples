using System;
using DependencyInversion_Orders_Begin.Logic;
using DependencyInversion_Orders_Begin.Logic.Carts;
using DependencyInversion_Orders_Begin.Logic.Orders;

namespace DependencyInversion_Orders_Begin
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

            // WebSite
            Console.WriteLine("1. Website order:");
            var onlineOrder = new OnlineOrder(cart, customer, creditCardPaymentDetails);
            onlineOrder.Checkout();
            Console.WriteLine($"Remaining money on card: {creditCardPaymentDetails.Money}");
            Console.WriteLine();

            // POS Credit Card
            Console.WriteLine("2. POS Credit Card order:");
            var posCreditOrder = new POSCreditOrder(cart, customer, creditCardPaymentDetails);
            posCreditOrder.Checkout();
            Console.WriteLine($"Remaining money on card: {creditCardPaymentDetails.Money}");
            Console.WriteLine();

            // POS Cash
            Console.WriteLine("3. POS Cash order:");
            var posCashOrder = new POSCashOrder(cart, customer);
            posCashOrder.Checkout();
            Console.WriteLine($"Remaining money on card: {creditCardPaymentDetails.Money}");
            Console.WriteLine();
        }
    }
}
