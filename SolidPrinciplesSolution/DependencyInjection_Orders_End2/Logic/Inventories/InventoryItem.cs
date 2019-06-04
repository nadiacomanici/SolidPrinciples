namespace DependencyInjection_Orders_End.Logic.Inventories
{
    public class InventoryItem
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int AvailableQuantity { get; set; }
        public double Price { get; private set; }

        public InventoryItem(int id, string name, int quantity, double price)
        {
            this.Id = id;
            this.Name = name;
            this.AvailableQuantity = quantity;
            this.Price = price;
        }
    }
}
