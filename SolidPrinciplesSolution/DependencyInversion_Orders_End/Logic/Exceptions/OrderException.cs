using System;

namespace DependencyInversion_Orders_End.Logic.Exceptions
{
    public class OrderException : Exception
    {
        public OrderException(string message) : base(message)
        { }
    }
}
