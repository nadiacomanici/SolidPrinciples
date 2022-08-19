using DependencyInversion_Orders_Demo.Logic.Carts;

namespace DependencyInversion_Orders_Demo.Logic.Orders
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
