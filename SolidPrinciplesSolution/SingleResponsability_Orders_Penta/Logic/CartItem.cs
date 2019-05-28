namespace SingleResponsability_Orders_Penta.Logic
{
    public class CartItem
    {
        public int Id { get; private set; }
        public int Quantity { get; set; }
        public CartItem(int id, int quantity)
        {
            this.Id = id;
            this.Quantity = quantity;
        }
    }
}
