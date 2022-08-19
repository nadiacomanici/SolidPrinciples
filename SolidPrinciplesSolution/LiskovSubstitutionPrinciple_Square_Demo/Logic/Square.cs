using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple_Square_Demo.Logic
{
    public class Square : Rectangle
    {
        public Square(int length) : base(length, length)
        {
        }
    }
}
