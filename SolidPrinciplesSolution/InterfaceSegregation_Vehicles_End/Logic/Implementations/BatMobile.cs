using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceSegregation_Vehicles_End.Logic.Contracts;

namespace InterfaceSegregation_Vehicles_End.Logic.Implementations
{
    public class BatMobile : IIdentifiableVehicle, IFlyable, IDrivable
    {
        public string LicencePlate { get; private set; }
        public int Speed { get; private set; }
        public Coordinate3D CurrentLocation { get; private set; }
        public void IncreaseSpeedBy(int value)
        {
            Speed += value;
        }

        public void DecreaseSpeedBy(int value)
        {
            Speed -= value;
        }

        public void DriveTo(float latitude, float longitude)
        {
            // TODO: implement math calculation for the car to go 
            // from current location to new location, using the current speed
            CurrentLocation = new Coordinate3D(latitude, longitude, CurrentLocation.Altitude);
        }

        public void RollWindowsDown()
        {
            Console.WriteLine("BatMobile.RollWindowsDown");
        }

        public void FlyTo(float latitude, float longitude, float altitude)
        {
            // TODO: implement math calculation for the car to go 
            // from current location to new location, using the current speed
            CurrentLocation = new Coordinate3D(latitude, longitude, altitude);
        }

        public void DefrostWings()
        {
            Console.WriteLine("BatMobile.DefrostWings");
        }

        public void DepressuriseCabin()
        {
            Console.WriteLine("BatMobile.DepressuriseCabin");
        }

        public BatMobile(float latitude, float longitude, float altitude)
        {
            this.LicencePlate = "BatMobile";
            this.CurrentLocation = new Coordinate3D(latitude, longitude, altitude);
        }
    }
}
