using System;
using System.Diagnostics;

namespace DependencyInversion_Orders_End.Logic
{
    public class Logger
    {
        public static void Error(string message, Exception ex)
        {
            Debug.WriteLine("---------------------------");
            Debug.WriteLine(message);
            Debug.WriteLine(ex.Message);
            Debug.WriteLine(ex.StackTrace);
            Debug.WriteLine("---------------------------");
        }
    }
}
