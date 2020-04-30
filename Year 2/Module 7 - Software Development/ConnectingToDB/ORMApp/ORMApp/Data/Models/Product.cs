using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ORMApp.Data.Models
{
    public class Product
    {
        public Product()
        { }
        public Product(string name, decimal price, int stock)
        {
            this.Name = name;
            this.Price = price;
            this.Stock = stock;
        }
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
