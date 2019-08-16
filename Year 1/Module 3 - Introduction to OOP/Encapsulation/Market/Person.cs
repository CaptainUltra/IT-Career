using System;
using System.Collections.Generic;

namespace Market
{
    public class Person
    {
        private string name;
        private int money;
        private List<Product> bag;
        public Person(string name, int money)
        {
            this.Name = name;
            this.Money = money;
            this.Bag = new List<Product>();
        }
        public bool AddProduct(Product product)
        {
            if(this.Money >= product.Price)
            {
                this.bag.Add(product);
                this.Money -= product.Price;
                return true;
            }
            return false;
        }
        public string BagItems()
        {
            List<string> baggie = new List<string>();
            foreach(var item in this.Bag)
            {
                baggie.Add(item.Name);
            }
            if(baggie.Count == 0) return "Nothing bought";
            return string.Join(", ", this.Bag);
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
        public string Money
        {
            get{return this.money;}
            set{
                if(value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
                }
        }
        public List<Product> Bag
        {
            get { return this.bag;}
            set { this.bag = value;}
        }
        
    }
}