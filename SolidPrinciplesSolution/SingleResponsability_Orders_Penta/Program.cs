using System;
using SingleResponsability_Orders_Penta.Logic;
using SingleResponsability_Orders_Penta.Logic.Orders;

namespace SingleResponsability_Orders_Penta
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

            var paymentCreditCard = new PaymentDetails()
            {
                CardNumber = "ABCD 1234 ABCD 1234 ABCD 1234",
                CardholderName = "Nadia C",
                ExpiresMonth = 1,
                ExpiresYear = 2020
            };

            // WebSite
            Console.WriteLine("1. Website order:");
            var websiteOrder = new WebsiteOrder(cart, customer, paymentCreditCard);
            websiteOrder.Checkout();
            Console.WriteLine();

            // POS Credit Card
            Console.WriteLine("2. POS Credit Card order:");
            var creditCardOrder = new CreditCardOrder(cart, customer, paymentCreditCard);
            creditCardOrder.Checkout();
            Console.WriteLine();

            // POS Cash
            Console.WriteLine("3. POS Cash order:");
            var cashOrder = new CashOrder(cart, customer);
            cashOrder.Checkout();
            Console.WriteLine();
        }
    }
}
