namespace AutomotivePark
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Car
    {
        private string manufacturer;
        private string model;
        private double loadCapacity;
        private List<Part> parts;
        private double fuel;
        public string Manufacturer
        {
            get { return this.manufacturer;}
            set 
            { 
                if(value.Length<3)
                {
                    throw new System.ArgumentException("Invalid manufacturer name!");
                }
                this.manufacturer = value;
            }
        }
        public string Model
        {
            get { return this.model;}
            set 
            { 
                if(value.Length<3)
                {
                    throw new System.ArgumentException("Invalid model name!");
                }
                this.model = value;
            }
        }
        public double LoadCapacity
        {
            get { return this.loadCapacity;}
            set 
            { 
                if(value < 0.00)
                {
                    throw new System.ArgumentException("Invalid load capacity!");
                }
                this.loadCapacity = value;
            }
        }
        
        public List<Part> Parts
        {
            get { return this.parts;}
            set { this.parts = value;}
        }
        public double Fuel
        {
            get { return this.fuel;}
            set { this.fuel = value;}
        }
        public Car(string manufacturer, string model, double loadCapacity)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.loadCapacity = loadCapacity;
            this.Fuel = 100;
            this.Parts = new List<Part>();
            Car.OrdersCount++;
        }
        public double GetCarPrice()
        {
            double sum = 0;
            sum = this.Parts.Sum(x => x.Price);
            return sum;
        }

        /*public ReadOnlyCollection<Part> Parts
        {
            //TODO: Добавете вашия код тук …
        }*/

        public void AddPart(Part part)
        {
            this.Parts.Add(part);
        }

        public void AddMultipleParts(List<Part> passedParts)
        {
            foreach (var part in passedParts)
            {
                this.Parts.Add(part);
            }      
        }

        public void RemovePartByName(string name)
        {
            this.Parts.Remove(parts.FirstOrDefault(x => x.Name == name));
        }

        public List<Part> GetPartsWithPriceAbove(double price)
        {
            return this.Parts.OrderByDescending(x => x.Price > price).ToList();
        }

        public Part GetMostExpensivePart()
        {
            return this.Parts.OrderByDescending(x => x.Price).FirstOrDefault();
        }

        public static int OrdersCount=0;

        public void Drive(double distance)
        {
            if((this.Fuel -= this.LoadCapacity * 0.2 * distance) < 0)
            {
                throw new System.ArgumentException("Drive not possible!");
            }
            this.Fuel -= this.LoadCapacity * 0.2 * distance;
        }

        public bool ContainsPart(string partName)
        {
            if(this.Parts.Contains(this.Parts.FirstOrDefault(x => x.Name == partName)))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append(this.Model.ToUpper());
            s.Append(" made by");
            s.Append(this.Manufacturer);
            s.Append("\r\nAvailable parts:\r\n");
            foreach (var part in this.Parts)
            {
                s.Append($"{part.ToString()}\r\n");
            }
            s.Append($"With total price of: {this.GetCarPrice():F2} lv.");
            return s.ToString();
        }
    }
}