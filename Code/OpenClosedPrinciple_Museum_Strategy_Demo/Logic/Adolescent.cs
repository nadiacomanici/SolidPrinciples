using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple_Museum_Strategy_Demo.Logic
{
    class Adolescent : Person
    {
        public Adolescent(string name, int age) : base(name, age)
        {

        }

        public override double GetTicketMultiplier()
        {
            return 0.75;
        }
    }
}
