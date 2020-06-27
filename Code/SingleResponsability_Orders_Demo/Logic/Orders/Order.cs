using System;
using System.Collections.Generic;
using SingleResponsability_Orders_Demo.Logic.Exceptions;

namespace SingleResponsability_Orders_Demo.Logic.Orders
{
    public abstract class Order
    {
        protected Cart cart;
        private Customer customer;

        public Order(Cart cart, Customer customer)
        {
            this.cart = cart;
            this.customer = customer;
        }

        public abstract void Checkout();
    }
}
