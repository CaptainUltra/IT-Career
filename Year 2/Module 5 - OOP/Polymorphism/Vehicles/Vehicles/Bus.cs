using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Vehicles
{
    public class Bus : Vehicle
    {
        private const double airConditionerFuelConsumption = 1.4;
        public Bus(double fuelQuiantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuiantity, fuelConsumption, tankCapacity)
        {
        }
        public override void Drive(double distance)
        {
            double currentFuelConsumption = this.FuelConsumption;
            if(!IsVehicleEmpty)
            {
                currentFuelConsumption += airConditionerFuelConsumption;
            }
            double neededFuel = distance * currentFuelConsumption;
            if (this.FuelQuantity < neededFuel)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }
            this.FuelQuantity -= neededFuel;
            System.Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }
    }
}
