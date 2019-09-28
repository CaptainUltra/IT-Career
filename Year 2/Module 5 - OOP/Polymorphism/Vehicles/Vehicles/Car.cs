using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Vehicles
{
    public class Car : Vehicle
    {
        private const double airConditionerConsumption = 0.9;
        public Car(double fuelQuiantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuiantity, fuelConsumption, tankCapacity)
        {
            this.FuelConsumption += airConditionerConsumption;
        }
    }
}
