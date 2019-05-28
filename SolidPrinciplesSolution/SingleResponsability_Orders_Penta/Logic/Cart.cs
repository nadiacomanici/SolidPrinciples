using System.Collections.Generic;

namespace SingleResponsability_Orders_Penta.Logic
{
    public class Cart
    {
        public List<CartItem> Items { get; private set; }

        public Cart()
        {
            this.Items = new List<CartItem>();
        }
    }
}
