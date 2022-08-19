using System;
using InterfaceSegregation_Vehicles_Demo.Logic.Contracts;

namespace InterfaceSegregation_Vehicles_Demo.Logic.Implementations
{
    public class Airplane : IVehicle
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
            throw new NotImplementedException();
        }

        public void RollWindowsDown()
        {
            throw new NotImplementedException();
        }
        
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
