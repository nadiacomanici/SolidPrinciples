using DependencyInjection_Orders_Begin.Logic.Carts;

namespace DependencyInjection_Orders_Begin.Logic.Orders
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
