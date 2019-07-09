namespace InterfaceSegregation_Vehicles_Begin.Logic.Contracts
{
    public interface IVehicle
    {
        string LicencePlate { get; }
        int Speed { get; }
        Coordinate3D CurrentLocation { get; }

        void IncreaseSpeedBy(int value);
        void DecreaseSpeedBy(int value);

        void DriveTo(float latitude, float longitude);
        void RollWindowsDown();

        void FlyTo(float latitude, float longitude, float altitude);
        void DefrostWings();
        void DepressuriseCabin();
    }
}
