using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Vehicles
{
    class Truck : Vehicle
    {
        private const double airConditionerConsumption = 1.6;
        private const double RefuelingLoss = 0.95;
        public Truck(double fuelQuiantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuiantity, fuelConsumption, tankCapacity)
        {
            this.FuelConsumption += airConditionerConsumption;
        }
        public override void Refuel(double fuelAmount)
        {
            base.Refuel(fuelAmount * Truck.RefuelingLoss);
        }
    }
}
