using System;
using DependencyInversion_DateTime_Demo.Logic;

namespace DependencyInversion_DateTime_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var greeter = new TimeOfDayGreeter();
            Console.WriteLine(greeter.GetProperGreeting("Nadia"));
        }
    }
}
