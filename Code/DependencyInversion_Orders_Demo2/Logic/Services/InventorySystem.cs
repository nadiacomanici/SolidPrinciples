﻿namespace SingleResponsability_Orders_Demo.Logic
{
    public class InventorySystem : IInventorySystem
    {
        public void Reserve(int itemId, int quantity)
        {
            // check that the quantity is available
            // if it is, reserve it
            // if it isn't, throw an InsufficientInventoryException
        }
    }
}