namespace Restaurant
{
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;
    public class Meal
    {
        private string name;
        private string type;
        private List<Product> products;
        private int ordered;
        private double price;
        public Meal(string name, string type)
        {
            this.Name = name;
            this.Type = type;
            this.Products = new List<Product>();
            this.Ordered = 0;
        }
        public Meal(string name, string type, List<Product> products)
        {
            this.Name = name;
            this.Type = type;
            this.Products = products;
            this.Ordered = 0;
        }
        public void AddProduct(Product p)
        {
            this.Products.Add(p);
        }
        public bool ContainsProduct(string name)
        {
            if(this.Products.Contains(this.Products.FirstOrDefault(x => x.Name == name)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void PrintRecipe()
        {
            StringBuilder s = new StringBuilder();
            s.Append(new string('-',25));
            s.Append("\r\n");
            s.Append($"{this.Name} RECIPE");
            s.Append("\r\n");
            s.Append(new string('-',25));
            s.Append("\r\n");
            foreach (var product in this.Products)
            {
                s.Append(product.ToString());
                s.Append("\r\n");
            }
            s.Append(new string('-',25));
            System.Console.WriteLine(s.ToString());
        }
        public override string ToString()
        {
            return $"{this.name} - {this.type}";
        }
        public double CalculatePrice()
        {
            return this.products.Sum(element => element.Price) + this.products.Sum(element => element.Price) * 0.30;
        }
        public double Price
        {
            get
            {
                this.price = CalculatePrice();
                return this.price;
            }
        }
        public void Order()
        {
            this.Ordered++;
        }
        public static Meal GetSpecialty(Dictionary<string, Meal> meals)
        {
            var meal = meals.OrderByDescending(x => x.Value.Ordered).FirstOrDefault().Value;
            return meal;
        }
        public static Meal RecommendByPrice(double price, Dictionary<string, Meal> meals)
        {
            return meals.Where(element => (element.Value.Price <= price))
                .OrderByDescending(element => element.Value.Price).First().Value;
        }

        public static Meal RecommendByPriceAndType(double price, string type, Dictionary<string, Meal> meals)
        {
            return meals.Where(element => (element.Value.Price <= price) && (element.Value.type == type))
                .OrderByDescending(element => element.Value.Price).First().Value;
        }
        public string Name
        {
            get { return this.name; }
            set 
            { 
                if(value.Length < 3) throw new System.ArgumentException("Invalid Command!");
                this.name = value;
            }
        }
        public string Type
        {
            get { return this.type; }
            set 
            { 
                if(value.Length == 0) throw new System.ArgumentException("Invalid Command!");
                this.type = value; 
            }
        }
        public List<Product> Products
        {
            get { return this.products; }
            set { this.products = value; }
        }
        public int Ordered
        {
            get { return this.ordered; }
            set { this.ordered = value; }
        }
    }
}