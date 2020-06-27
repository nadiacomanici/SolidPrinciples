using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiskovSubstitutionPrinciple_Square_Demo.Logic;

namespace LiskovSubstitutionPrinciple_Square_Demo
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
