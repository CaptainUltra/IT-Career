namespace ChefsKingdom
{
    using System.Linq;
    public class Dish
    {
        private string name;
        private string foodGroup;
        private double price;
        public Dish(string name, string foodGroup, double price)
        {
            this.Name = name;
            this.Price = price;
            this.FoodGroup = foodGroup;
        }

        public string Name
        {
            get { return this.name;}
            set {this.name = value;}
        }
        public string FoodGroup
        {
            get { return this.foodGroup;}
            set { this.foodGroup = value;}
        }
        public double Price
        {
            get { return this.price;}
            set 
            { 
                if(value > 0.00)
                {
                this.price = value;
                }
                else throw new System.ArgumentException("Invalid dish price!");
            }
        }
        public override string ToString()
        {
            return $"Dish: {this.Name} of type {this.FoodGroup}. Price {this.Price:f2}";
        }
    }
}