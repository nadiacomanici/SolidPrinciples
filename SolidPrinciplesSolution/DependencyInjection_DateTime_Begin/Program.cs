using System;
using DependencyInjection_DateTime_Begin.Logic;

namespace DependencyInjection_DateTime_Begin
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
