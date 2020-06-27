using System.Collections.Generic;

namespace SingleResponsability_Orders_Demo.Logic.Services
{
    public interface IInventoryManager
    {
        void ReserveInventory(List<CartItem> items);
    }
}