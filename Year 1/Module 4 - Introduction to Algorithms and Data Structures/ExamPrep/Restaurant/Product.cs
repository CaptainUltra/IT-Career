namespace Restaurant
{
    public class Product
    {
        private string name;
        private Product next;
        public Product(string name)
        {
            this.Name = name;
        }
        public override string ToString()
        {
            return $"Product {name}";
        }
        public string Name { get => name; set => name = value; }
        public Product Next { get => next; set => next = value; }
    }
}