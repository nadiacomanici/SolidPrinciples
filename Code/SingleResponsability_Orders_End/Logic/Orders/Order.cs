namespace SingleResponsability_Orders_End.Logic.Orders
{
    public abstract class Order
    {
        protected Cart _cart;
        protected Customer _customer;

        public Order(Cart cart, Customer customer)
        {
            _cart = cart;
            _customer = customer;
        }

        public abstract void Checkout();
    }
}
