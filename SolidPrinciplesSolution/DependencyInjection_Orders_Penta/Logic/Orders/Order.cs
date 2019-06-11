using DependencyInjection_Orders_Penta.Logic.Carts;

namespace DependencyInjection_Orders_Penta.Logic.Orders
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
