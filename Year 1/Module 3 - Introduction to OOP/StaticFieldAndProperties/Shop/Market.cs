using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop
{
    public static class Market
    {
        private static List<Product> products;
        static Market()
        {
            products = new List<Product>();
        }
        public static void Sell(string barcode, double quantity)
        {
            var prod = products.Where(x => x.Barcode == barcode).FirstOrDefault();
            if(prod.Quantity >= quantity) prod.Quantity -= quantity;
            else System.Console.WriteLine("Not enough quantity");

        }
        public static void Add(string barcode, string name, double price, double quantity)
        {
            Product prod = new Product(name, barcode, price, quantity);
            products.Add(prod);
        }
        public static void Update(string barcode, double quantity)
        {
            if(products.Any(x => x.Barcode == barcode))
            {
                var prod = products.Where(x => x.Barcode == barcode).FirstOrDefault();
                prod.Quantity += quantity;
            }
        }
        public static void PrintA()
        {
            var prods = products.Where(x => x.Quantity > 0);
            foreach (var item in prods)
            {
                System.Console.WriteLine($"{item.Name} ({item.Barcode})");
            }
        }
        public static void PrintU()
        {
            var prods = products.Where(x => x.Quantity == 0);
            foreach (var item in prods)
            {
                System.Console.WriteLine($"{item.Name} ({item.Barcode})");
            }
        }
        public static void PrintD()
        {
            var prods = products.OrderByDescending(x => x.Quantity);
            foreach (var item in prods)
            {
                System.Console.WriteLine($"{item.Name} ({item.Barcode})");
            }
        }
        public static double Calculate()
        {
            double sum = 0;
            foreach (var item in products)
            {
                sum += item.Quantity * item.Price;
            }
            return sum;
        }
    }
}