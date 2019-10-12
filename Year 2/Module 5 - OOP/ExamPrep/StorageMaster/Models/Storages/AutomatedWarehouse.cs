namespace StorageMaster.Models.Storages
{
    using Models.Vehicles;
    public class AutomatedWarehouse : Storage
    {
        private const int AutomatedWarehouseCapacity = 1;
        private const int AutomatedWarehouseGarageSlots = 2;
        private static readonly Vehicle[] AutomatedWarehouseVehicles =
        {
            new Truck()
        };
        public AutomatedWarehouse(string name)
            : base(name, AutomatedWarehouseCapacity, AutomatedWarehouseGarageSlots, AutomatedWarehouseVehicles)
        {
        }
    }
}