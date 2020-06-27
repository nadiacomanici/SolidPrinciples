using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple_Square_Begin.Logic
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override int GetArea()
        {
            return Height * Width;
        }
    }
}
