using ORMApp.Data;
using ORMApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORMApp.Business
{
    public class ProductController
    {
        private ProductDBContext context;
        public ProductController()
        {
            this.context = new ProductDBContext();
        }

        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }

        public Product Get(int id)
        {
            var product = this.context.Products.FirstOrDefault(x => x.Id == id);

            return product;
        }
        public void AddProduct(Product product)
        {
            this.context.Products.Add(product);
            this.context.SaveChanges();
        }

        public void Update(int id, Product product)
        {
            var productItem = this.Get(id);

            this.context.Entry(productItem).Entity.Name = product.Name;
            this.context.Entry(productItem).Entity.Price = product.Price;
            this.context.Entry(productItem).Entity.Stock = product.Stock;
            this.context.SaveChanges();
        }

        public void Delete(int id)
        {
            var productItem = this.Get(id);
            this.context.Products.Remove(productItem);
            this.context.SaveChanges();
        }
    }
}
