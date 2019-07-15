using System;
using LiskovSubstitutionPrinciple_Square_End.Logic;

namespace LiskovSubstitutionPrinciple_Square_End
{
    class Program
    {
        static void Main(string[] args)
        {
            //var shape = new Rectangle(10, 30);
            var shape = new Square(10);

            Console.WriteLine($"Initially: {shape.Width} x {shape.Height} = {shape.GetArea()}");

            shape.Width = 20;

            Console.WriteLine($"After update width: {shape.Width} x {shape.Height} = {shape.GetArea()}");
            Console.WriteLine();
        }
    }
}
