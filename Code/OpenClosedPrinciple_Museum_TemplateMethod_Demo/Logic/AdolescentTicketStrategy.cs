using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple_Museum_TemplateMethod_Demo.Logic
{
    class AdolescentTicketStrategy : TicketStrategy
    {
        public override double GetTicketMultiplier()
        {
            return 0.75;
        }
    }

}