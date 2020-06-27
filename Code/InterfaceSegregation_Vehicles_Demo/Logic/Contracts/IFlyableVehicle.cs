namespace InterfaceSegregation_Vehicles_Begin.Logic.Contracts
{
    public interface IFlyableVehicle
    {
        void FlyTo(float latitude, float longitude, float altitude);
        void DefrostWings();
        void DepressuriseCabin();
    }
}
