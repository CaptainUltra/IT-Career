using System;

namespace Market
{
    public class Product
    {
        private string name;
        private int price;
        public Product(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name
            {
                get{return this.name;}
                set{
                    if(value.Length == 0)
                    {
                        throw new ArgumentException("Name cannot be empty");
                    }
                    this.name = value;
                    }
            }
        public int Price
            {
                get{return this.price;}
                set{
                    if(value < 0)
                    {
                        throw new ArgumentException("Price cannot be negative");
                    }
                    this.price = value;
                    }
            }
    }
}