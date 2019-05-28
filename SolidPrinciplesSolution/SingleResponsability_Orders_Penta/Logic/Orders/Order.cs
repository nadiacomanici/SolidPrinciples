using System;
using SingleResponsability_Orders_Penta.Logic.Exceptions;

namespace SingleResponsability_Orders_Penta.Logic
{
    public abstract class Order
    {
        protected Cart cart;
        protected Customer customer;

        public Order(Cart cart, Customer customer)
        {
            this.cart = cart;
            this.customer = customer;
        }

        public abstract void Checkout();

    }
}
