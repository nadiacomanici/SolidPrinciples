using System;
using InterfaceSegregation_Vehicles_Penta.Logic.Contracts;
using InterfaceSegregation_Vehicles_Penta.Logic.Implementations;
using InterfaceSegregation_Vehicles_Penta.Logic.Contracts;

namespace InterfaceSegregation_Vehicles_Penta.Logic.Implementations
{
    public class Car : Vehicle, IDrivableVehicle
    {
        public void DriveTo(float latitude, float longitude)
        {
            // TODO: implement math calculation for the car to go 
            // from current location to new location, using the current speed
            CurrentLocation = new Coordinate3D(latitude, longitude, CurrentLocation.Altitude);
        }

        public void RollWindowsDown()
        {
            Console.WriteLine("Car.RollWindowsDown");
        }

        public Car(string licencePlate, float latitude, float longitude)
        {
            this.LicencePlate = licencePlate;
            this.CurrentLocation = new Coordinate3D(latitude, longitude, 0);
        }
    }
}
