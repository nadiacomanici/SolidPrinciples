using System;
using InterfaceSegregation_Vehicles_Penta.Logic.Contracts;
using InterfaceSegregation_Vehicles_Penta.Logic.Implementations;
using InterfaceSegregation_Vehicles_Penta.Logic.Contracts;

namespace InterfaceSegregation_Vehicles_Penta.Logic.Implementations
{
    public class BatMobile : Vehicle, IFlyableVehicle, IDrivableVehicle
    {
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
