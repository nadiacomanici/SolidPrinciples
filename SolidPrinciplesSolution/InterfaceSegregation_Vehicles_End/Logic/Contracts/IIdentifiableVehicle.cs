using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation_Vehicles_End.Logic.Contracts
{
    public interface IIdentifiableVehicle : ISpeedable
    {
        string LicencePlate { get; }
        Coordinate3D CurrentLocation { get; }
    }
}
