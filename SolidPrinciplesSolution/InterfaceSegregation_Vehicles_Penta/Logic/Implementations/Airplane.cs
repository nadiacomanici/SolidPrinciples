using System;
using InterfaceSegregation_Vehicles_Penta.Logic.Contracts;
using InterfaceSegregation_Vehicles_Penta.Logic.Implementations;
using InterfaceSegregation_Vehicles_Penta.Logic.Contracts;

namespace InterfaceSegregation_Vehicles_Penta.Logic.Implementations
{
    public class Airplane : Vehicle, IFlyableVehicle
    {        
        public void FlyTo(float latitude, float longitude, float altitude)
        {
            // TODO: implement math calculation for the car to go 
            // from current location to new location, using the current speed
            CurrentLocation = new Coordinate3D(latitude, longitude, altitude);
        }

        public void DefrostWings()
        {
            Console.WriteLine("Airplane.DefrostWings");
        }

        public void DepressuriseCabin()
        {
            Console.WriteLine("Airplane.DepressuriseCabin");
        }

        public Airplane(string licencePlate, float latitude, float longitude, float altitude)
        {
            this.LicencePlate = licencePlate;
            this.CurrentLocation = new Coordinate3D(latitude, longitude, altitude);
        }
    }
}
