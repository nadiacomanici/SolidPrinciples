using System;

namespace DependencyInversion_Orders_Begin.Logic.Exceptions
{
    public class OrderException : Exception
    {
        public OrderException(string message) : base(message)
        { }
    }
}
