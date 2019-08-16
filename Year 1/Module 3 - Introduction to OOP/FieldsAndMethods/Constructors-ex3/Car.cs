namespace Constructors_ex3
{
    using System.Collections.Generic;
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tyre> tyres;
        public Car(string model, Engine engine, Cargo cargo, List<Tyre> tyres)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tyres = tyres;
        }
        public string Model
        {
            get { return this.model;}
            set { this.model = value;}
        }
        public Engine Engine
        {
            get { return this.engine;}
            set { this.engine = value;}
        }
        public Cargo Cargo
        {
            get { return this.cargo;}
            set { this.cargo = value;}
        }
        public List<Tyre> Tyres
        {
            get { return this.tyres;}
            set { this.tyres = value;}
        }
    }
}