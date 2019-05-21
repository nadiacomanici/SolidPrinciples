using System;
using SingleResponsability_Orders_End.Logic;
using SingleResponsability_Orders_End.Logic.Orders;

namespace SingleResponsability_Orders_End
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
            
            var creditCardPaymentDetails = new CreditCardPaymentDetails()
            {
                CardNumber = "ABCD 1234 ABCD 1234 ABCD 1234",
                CardholderName = "Nadia C",
                ExpiresMonth = 1,
                ExpiresYear = 2020
            };

            // WebSite
            Console.WriteLine("1. Website order:");
            var onlineOrder = new OnlineOrder(cart, customer, creditCardPaymentDetails);
            onlineOrder.Checkout();
            Console.WriteLine();

            // POS Credit Card
            Console.WriteLine("2. POS Credit Card order:");
            var posCreditOrder = new POSCreditOrder(cart, customer, creditCardPaymentDetails);
            posCreditOrder.Checkout();
            Console.WriteLine();

            // POS Cash
            Console.WriteLine("3. POS Cash order:");
            var posCashOrder = new POSCashOrder(cart, customer);
            posCashOrder.Checkout();
            Console.WriteLine();
        }
    }
}
