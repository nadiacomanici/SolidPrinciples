using System;

namespace SingleResponsability_Orders_Penta.Logic.Exceptions
{
    public class OrderException : Exception
    {
        public OrderException(string message) : base(message)
        { }
    }
}
