namespace SingleResponsability_Orders_End.Logic.Orders
{
    public class POSCashOrder : Order
    {
        public POSCashOrder(Cart cart, Customer customer)
            : base(cart, customer)
        {
        }

        public override void Checkout()
        {
            base.Checkout();
        }
    }
}
