namespace AnimalKingdom2
{
    public interface IAnimal : IMakeNoise, IMakeTrick
    {
        void Perform();
    }
}