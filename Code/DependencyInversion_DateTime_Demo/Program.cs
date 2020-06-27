using System;
using DependencyInversion_DateTime_Begin.Logic;

namespace DependencyInversion_DateTime_Begin
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
