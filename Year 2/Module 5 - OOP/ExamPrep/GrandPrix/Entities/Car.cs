namespace GrandPrix.Entities
{
    using System;
    using Tyres;
    public class Car
    {
        private const double FuelCapacity = 160;
        private double fuelAmmount;
        public Car(int hp, double fuelAmmount, Tyre tyre)
        { 
            this.Hp = hp;
            this.FuelAmmount = fuelAmmount;
            this.Tyre = tyre;
        }
        public int Hp { get; }
        public double FuelAmmount 
        {
            get
            {
                return this.fuelAmmount;
            } 
            private set
            {
                if(value < 0)
                {
                    throw new Exception(ErrorMessages.OutOfFuel);
                }
                this.fuelAmmount = Math.Min(value, FuelCapacity);
            }
        }
        public Tyre Tyre{get; private set;}
    }
}