using System.Collections.Generic;

namespace Restaurant
{
    public class Fridge
    {
        private Product head;
        private Product tail;
        private int count;

        public Fridge() { }

        public int Count
        {
            get { return this.count; }
        }

        public void AddProduct(string productName)
        {
            this.count++;
            if (head == null)
            {
                this.head = this.tail = new Product(productName);
            }
            else
            {
                var newProduct = new Product(productName);
                this.tail.Next = newProduct;
                this.tail = newProduct;
            }
        }

        public string[] CookMeal(int start, int end)
        {
            var meals = ProvideInformationAboutAllProducts();
            if(end > meals.Length)
            {
                end = meals.Length;
            }
            var result = new List<string>();
            for(int i = start; i < end; i++)
            {
                result.Add(meals[i]);
            }
            return result.ToArray();
        }

        public string RemoveProductByIndex(int index)
        {
            if (index == 0)
            {
                var name = head.Name;
                head = head.Next;
                count--;
                return name;
            }
            var currentProduct = this.head;
            Product prevProduct = null;
            for (int i = 1; i <= index; i++)
            {
                if (prevProduct != null)
                {
                    var name = currentProduct.Name;
                    if (tail == currentProduct)
                    {
                        name = this.tail.Name; ;
                        tail = prevProduct;
                        //return name;
                    }
                    prevProduct.Next = currentProduct.Next;
                    this.count--;
                    return name;
                }

                prevProduct = currentProduct;
                currentProduct = currentProduct.Next;
            }
            return null;
        }

        public string RemoveProductByName(string name)
        {
            if (head.Name == name)
            {
                head = head.Next;
                count--;
                return name;
            }
            var currentProduct = this.head;
            while (currentProduct != null)
            {
                if (currentProduct.Next.Name == name)
                {
                    if (currentProduct.Next == tail)
                    {
                        tail = currentProduct;
                        tail.Next = null;
                    }
                    else
                    {
                        currentProduct.Next = currentProduct.Next.Next;
                    }
                    count--;
                    return name;
                }
                currentProduct = currentProduct.Next;
            }
            return null;

        }

        public bool CheckProductIsInStock(string name)
        {
            Product currentProduct = this.head;
            while(currentProduct != null)
            {
                if(currentProduct.Name == name)
                {
                    return true;
                }
                currentProduct = currentProduct.Next;
            }
            return false;
        }

        public string[] ProvideInformationAboutAllProducts()
        {
            var allProducts = new List<string>();
            Product currentProduct = this.head;
            while(currentProduct != null)
            {
                allProducts.Add(currentProduct.ToString());
                currentProduct = currentProduct.Next;
            }
            return allProducts.ToArray();
        }
    }
}