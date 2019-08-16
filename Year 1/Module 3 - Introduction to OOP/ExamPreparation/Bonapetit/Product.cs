namespace Restaurant
{
    using System.Collections.Generic;
    using System.Linq;
    public class Product
    {
        private string name;
        private double price;
        private int weight;
        public Product(string name, double price, int weight)
        {
            this.Name = name;
            this.Price = price;
            this.Weight = weight;
        }
        public static Product GetCheapestProduct(Dictionary<string, Product> products)
        {
            return products.OrderBy(x => x.Value.Price).First().Value;
        }
        public override string ToString()
        {
            return $"{this.Name} - {this.Weight}";
        }
        public string Name
        {
            get { return this.name;}
            set 
            { 
                if(value.Length<3)throw new System.ArgumentException("Invalid Command!");
                this.name = value;
            }
        }
        public double Price
        {
            get { return this.price;}
            set 
            { 
                if(value < 0.01) throw new System.ArgumentException("Invalid Command!");
                this.price = value;
            }
        }
        public int Weight
        {
            get { return this.weight;}
            set 
            { 
                if(value <= 0)throw new System.ArgumentException("Invalid Command!");
                this.weight = value;
            }
        }

    }
}