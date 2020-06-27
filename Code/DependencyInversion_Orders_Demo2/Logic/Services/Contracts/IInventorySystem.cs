namespace SingleResponsability_Orders_Demo.Logic
{
    public interface IInventorySystem
    {
        void Reserve(int itemId, int quantity);
    }
}