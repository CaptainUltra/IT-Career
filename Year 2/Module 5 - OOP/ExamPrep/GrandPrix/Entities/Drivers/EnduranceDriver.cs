namespace GrandPrix.Entities.Drivers
{
    public class EnduranceDriver : Driver
    {
        private const double fuelConsumptionPerKm = 1.5;
        protected EnduranceDriver(string name, Car car) 
            : base(name, car, fuelConsumptionPerKm)
        {
        }
    }
}