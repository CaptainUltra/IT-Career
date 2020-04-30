using ORMApp.Business;
using ORMApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ORMApp.Presentation
{
    public class Display
    {
        private const int CloseOperationId = 6;
        private ProductController productController = new ProductController();
        public Display()
        {
            Input();
        }
        private void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "MENU" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all entries");
            Console.WriteLine("2. Add new entry");
            Console.WriteLine("3. Update entry");
            Console.WriteLine("4. Fetch entry by ID");
            Console.WriteLine("5. Delete entry by ID");
            Console.WriteLine("6. Exit");
        }

        private void Input()
        {
            var operation = -1;
            do
            {
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        {
                            ListAll();
                            break;
                        }
                    case 2:
                        {
                            Add();
                            break;
                        }
                    case 3:
                        {
                            Update();
                            break;
                        }
                    case 4:
                        {
                            Fetch();
                            break;
                        }
                    case 5:
                        {
                            Delete();
                            break;
                        }
                    default:
                        break;
                }
            } while (operation != CloseOperationId);
        }

        private void Delete()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            Product product = productController.Get(id);
            if (product != null)
            {
                productController.Delete(id);
                Console.WriteLine("Deleted.");
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        private void Fetch()
        {
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            Product product = productController.Get(id);
            if (product != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine($"ID: {product.Id}");
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"Price: {product.Price}");
                Console.WriteLine($"Stock: {product.Stock}");
                Console.WriteLine(new string('-', 40));
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        private void Update()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Product product = productController.Get(id);
            if (product != null)
            {
                Console.WriteLine("Enter name: ");
                product.Name = Console.ReadLine();
                Console.WriteLine("Enter price: ");
                product.Price = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter stock: ");
                product.Stock = int.Parse(Console.ReadLine());

                productController.Update(id, product);
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        private void Add()
        {
            Product product = new Product();
            Console.WriteLine("Enter name: ");
            product.Name = Console.ReadLine();
            Console.WriteLine("Enter price: ");
            product.Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter stock: ");
            product.Stock = int.Parse(Console.ReadLine());

            productController.AddProduct(product);
        }

        private void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "PRODUCTS" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));

            var products = productController.GetAll();

            foreach (var product in products)
            {
                Console.WriteLine("{0} {1} {2} {3}", product.Id, product.Name, product.Price, product.Stock);
            }
        }
    }
}
