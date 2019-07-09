using System;
using System.Collections.Generic;
using InterfaceSegregation_Vehicles_Penta.Logic.Contracts;
using InterfaceSegregation_Vehicles_Penta.Logic.Implementations;

namespace InterfaceSegregation_Vehicles_Penta
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVehicle> vehicles = new List<IVehicle>();

            var duster = new Car("BV 08 XLN", 45.657974f, 25.601198f);
            duster.IncreaseSpeedBy(60);

            var boeing = new Airplane("Vjjjj 1024", 44.439663f, 26.096306f, 600);
            boeing.IncreaseSpeedBy(300);

            var batMobile = new BatMobile(45, 25, 1000);
            batMobile.IncreaseSpeedBy(100);

            vehicles.Add(duster);
            vehicles.Add(boeing);
            vehicles.Add(batMobile);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"'{vehicle.LicencePlate}' has {vehicle.Speed} km/h");
            }

            foreach (var vehicle in vehicles)
            {
                vehicle.DecreaseSpeedBy(30);
                Console.WriteLine($"'{vehicle.LicencePlate}' has {vehicle.Speed} km/h");
            }
        }
    }
}
