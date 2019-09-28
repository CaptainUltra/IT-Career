using System;

namespace AnimalKingdom2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            Trainer trainer = new Trainer(dog);
            trainer.Make();
            trainer.Entity = cat;
            trainer.Make();
        }
    }
}
