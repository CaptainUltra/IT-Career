namespace AutomotivePark
{
    public class Part
    {
        private string name;
        private double price;
        public string Name
        {
            get { return this.name;}
            set 
            { 
                if(value.Length<5)
                {
                    throw new System.ArgumentException("Invalid part name!");
                }
                this.name = value;
            }
        }
        public double Price
        {
            get { return this.price;}
            set 
            {
                if(value < 0.00)
                {
                   throw new System.ArgumentException("Price should be positive!");
                } 
                this.price = value;
            }
        }
        public Part(string name)
        {
            this.Name = name;
            this.Price = 25;
        }
        public Part(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"-> {this.Name} - {this.Price:F2}";
        }
    }
}