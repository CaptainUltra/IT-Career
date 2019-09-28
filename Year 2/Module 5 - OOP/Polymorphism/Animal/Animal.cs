namespace Animal
{
    public class Animal
    {
        private string name;
        private string favouriteFood;
        public virtual string ExplainMyself()
        {
            return $"I am {this.Name} and my food is {this.FavouriteFood}";
        }
        public string Name { get; set; }
        public string FavouriteFood { get; set; }
    }
}