using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceSegregation_Vehicles_Penta.Logic.Contracts;

namespace InterfaceSegregation_Vehicles_Penta.Logic.Contracts
{
    public interface IFlyableVehicle
    {
        void FlyTo(float latitude, float longitude, float altitude);
        void DefrostWings();
        void DepressuriseCabin();
    }
}
