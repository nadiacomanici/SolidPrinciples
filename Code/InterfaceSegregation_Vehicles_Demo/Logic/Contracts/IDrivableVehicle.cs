namespace InterfaceSegregation_Vehicles_Begin.Logic.Contracts
{
    public interface IDrivableVehicle
    {
        void DriveTo(float latitude, float longitude);
        void RollWindowsDown();
    }
}
