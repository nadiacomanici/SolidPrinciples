using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation_Vehicles_End.Logic.Contracts
{
    public interface IFlyable
    {
        void FlyTo(float latitude, float longitude, float altitude);
    }
}
