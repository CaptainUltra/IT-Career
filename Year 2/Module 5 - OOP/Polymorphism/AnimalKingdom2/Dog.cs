namespace AnimalKingdom2
{
    public class Dog : IAnimal
    {
        public string MakeNoise()
        {
            return "Woof!";
        }

        public string MakeTrick()
        {
            return "Hold my paw, human!";
        }

        public void Perform()
        {
            System.Console.WriteLine(this.MakeNoise());
            System.Console.WriteLine(this.MakeTrick());
        }
    }
}