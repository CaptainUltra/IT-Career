using System;

namespace Shop
{
    public class Product
    {
        private string name;
        private string barcode;
        private double price;
        private double quantity;
        public Product(string name, string barcode, double price, double quantity)
        {
            this.Name = name;
            this.Barcode = barcode;
            this.Price = price;
            this.Quantity = quantity;
        }
        public string Name
        {
            get { return this.name;}
            set { this.name = value;}
        }
        public string Barcode
        {
            get { return this.barcode;}
            set { this.barcode = value;}
        }
        public double Price
        {
            get { return this.price;}
            set { this.price = value;}
        }
        public double Quantity
        {
            get { return this.quantity;}
            set { this.quantity = value;}
        }
        
    }
}