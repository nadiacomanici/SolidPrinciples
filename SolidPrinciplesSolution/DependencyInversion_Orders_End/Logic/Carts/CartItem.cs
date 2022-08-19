namespace DependencyInversion_Orders_End.Logic.Carts
{
    public class CartItem
    {
        public int Id { get; private set; }
        public int Quantity { get; private set; }
        public double Price { get; private set; }
        public string Name { get; private set; }

        public CartItem(int id, int quantity, double price, string name)
        {
            this.Id = id;
            this.Quantity = quantity;
            this.Price = price;
            this.Name = name;
        }
    }
}
