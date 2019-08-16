namespace Constructors_ex3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();
                string model = inputArgs[0];
                int engineSpeed = int.Parse(inputArgs[1]);
                int enginePower = int.Parse(inputArgs[2]);
                int cargoWeight = int.Parse(inputArgs[3]);
                string cargoType = inputArgs[4];
                List<Tyre> tyres = new List<Tyre>();
                for (int j = 0; j < 4; j+=2)
                {
                    double tyrePressure = double.Parse(inputArgs[5+j]);
                    int tyreAge = int.Parse(inputArgs[6+j]);
                    tyres.Add(new Tyre(tyreAge, tyrePressure));   
                }
                Engine engine = new Engine(engineSpeed,enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Car car = new Car(model, engine, cargo, tyres);
                cars.Add(car);
            }
            string command= Console.ReadLine();
            List<Car> resultCars = new List<Car>();
            if(command == "fragile")
            {
                resultCars = cars.Where(x => x.Cargo.CargoType == "fragile" && x.Tyres.Any(p => p.Pressure<1)).ToList();
            }
            else
            {
                resultCars = cars.Where(x => x.Cargo.CargoType == "flammable" && x.Engine.Power > 250).ToList();
            }
            foreach (var car in resultCars)
            {
                System.Console.WriteLine(car.Model);
            }
        }
    }
}
