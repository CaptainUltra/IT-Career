using System;

namespace Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            LawnMower lawnMower = new LawnMower();
            Airplane airplane = new Airplane();
            Truck truck = new Truck();

            MachineOperator mo = new MachineOperator(car);
            mo.Start();
            mo.Stop();
            mo.Entity = lawnMower;
            mo.Start();
            mo.Stop();
            mo.Entity = airplane;
            mo.Start();
            mo.Stop();
            mo.Entity = truck;
            mo.Start();
            mo.Stop();
            
        }
    }
}
