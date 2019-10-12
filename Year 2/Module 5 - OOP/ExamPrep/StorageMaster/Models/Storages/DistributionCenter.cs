namespace StorageMaster.Models.Storages
{
    using Models.Vehicles;
    public class DistributionCenter : Storage
    {
        private const int DistributionCenterCapacity = 1;
        private const int DistributionCenterGarageSlots = 5;
        private static readonly Vehicle[] DistributionCenterVehicles =
        {
            new Van(),
            new Van(),
            new Van()
        };
        public DistributionCenter(string name)
            : base(name, DistributionCenterCapacity, DistributionCenterGarageSlots, DistributionCenterVehicles)
        {
        }
    }
}