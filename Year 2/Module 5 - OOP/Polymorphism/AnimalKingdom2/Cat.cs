namespace AnimalKingdom2
{
    public class Cat : IAnimal
    {
        public string MakeNoise()
        {
            return "Meow!";
        }

        public string MakeTrick()
        {
            return "No trick for you! I'm too lazy!";
        }

        public void Perform()
        {
            System.Console.WriteLine(this.MakeNoise());
            System.Console.WriteLine(this.MakeTrick());
        }
    }
}