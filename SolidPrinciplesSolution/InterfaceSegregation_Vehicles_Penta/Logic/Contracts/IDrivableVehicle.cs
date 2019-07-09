using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceSegregation_Vehicles_Penta.Logic.Contracts;

namespace InterfaceSegregation_Vehicles_Penta.Logic.Contracts
{
    public interface IDrivableVehicle
    {
        void DriveTo(float latitude, float longitude);
        void RollWindowsDown();
    }
}
