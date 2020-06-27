using System.Collections.Generic;

namespace DependencyInversion_Orders_Begin.Logic.Carts
{
    public class Cart
    {
        public List<CartItem> Items { get; private set; }

        public Cart()
        {
            this.Items = new List<CartItem>();
        }

        public double TotalCost
        {
            get
            {
                double sum = 0;
                foreach (var item in Items)
                {
                    sum += item.Quantity * item.Price;
                }
                return sum;
            }
        }
    }
}
