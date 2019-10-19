namespace GrandPrix.Entities.Drivers
{
    public class AggressiveDriver : Driver
    {
        private const double fuelConsumptionPerKm = 2.7;
        protected AggressiveDriver(string name, Car car)
            : base(name, car, fuelConsumptionPerKm)
        { }
        public override double Speed => base.Speed * 1.3;
    }
}