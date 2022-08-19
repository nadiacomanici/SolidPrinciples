using System;
using SingleResponsability_Orders_Begin.Logic;

namespace SingleResponsability_Orders_Begin
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

            var order = new Order(cart, customer);

            var paymentCreditCard = new PaymentDetails()
            {
                PaymentMethod = PaymentMethod.CreditCard,
                CardNumber = "ABCD 1234 ABCD 1234 ABCD 1234",
                CardholderName = "Nadia C",
                ExpiresMonth = 1,
                ExpiresYear = 2020
            };

            var paymentCash = new PaymentDetails()
            {
                PaymentMethod = PaymentMethod.Cash
            };

            // WebSite
            Console.WriteLine("1. Website order:");
            order.Checkout(paymentCreditCard, true);
            Console.WriteLine();

            // POS Credit Card
            Console.WriteLine("2. POS Credit Card order:");
            order.Checkout(paymentCreditCard, false);
            Console.WriteLine();

            // POS Cash
            Console.WriteLine("3. POS Cash order:");
            order.Checkout(paymentCash, false);
            Console.WriteLine();
        }
    }
}
