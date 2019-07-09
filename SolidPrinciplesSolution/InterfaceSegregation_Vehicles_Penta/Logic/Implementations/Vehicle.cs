using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceSegregation_Vehicles_Penta.Logic;
using InterfaceSegregation_Vehicles_Penta.Logic.Contracts;

namespace InterfaceSegregation_Vehicles_Penta.Logic.Implementations
{
    public class Vehicle : IVehicle
    {
        public string LicencePlate { get; protected set; }
        public int Speed { get; private set; }
        public Coordinate3D CurrentLocation { get; protected set; }

        public void IncreaseSpeedBy(int value)
        {
            Speed += value;
        }

        public void DecreaseSpeedBy(int value)
        {
            Speed -= value;
        }
    }
}
