namespace InterfaceSegregation_Vehicles_Penta.Logic.Contracts
{
    public interface IVehicle
    {
        string LicencePlate { get; }
        int Speed { get; }
        Coordinate3D CurrentLocation { get; }

        void IncreaseSpeedBy(int value);
        void DecreaseSpeedBy(int value);
    }
}
