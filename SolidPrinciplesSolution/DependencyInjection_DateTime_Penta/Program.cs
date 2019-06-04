using System;
using DependencyInjection_DateTime_Begin.Logic;

namespace DependencyInjection_DateTime_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            IDateTimeProvider provider = new DateTimeProvider();
            var greeter = new TimeOfDayGreeter(provider);
            Console.WriteLine(greeter.GetProperGreeting("Nadia"));
        }
    }
}
