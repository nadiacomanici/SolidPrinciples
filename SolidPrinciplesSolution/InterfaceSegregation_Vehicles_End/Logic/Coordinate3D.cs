using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation_Vehicles_End.Logic
{
    public class Coordinate3D
    {
        public float Latitude { get; private set; }
        public float Longitude { get; private set; }
        public float Altitude { get; private set; }

        public Coordinate3D(float latitude, float longitude, float altitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Altitude = altitude;
        }
    }
}
