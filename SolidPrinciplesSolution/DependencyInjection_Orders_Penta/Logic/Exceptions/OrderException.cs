using System;

namespace DependencyInjection_Orders_Penta.Logic.Exceptions
{
    public class OrderException : Exception
    {
        public OrderException(string message) : base(message)
        { }
    }
}
