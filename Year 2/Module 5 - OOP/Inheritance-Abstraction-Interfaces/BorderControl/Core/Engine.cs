using System;
using BorderControl.Contracts;
using BorderControl.Models;
using System.Collections.Generic;

namespace BorderControl.Core
{
    public class Engine
    {
        private ICollection<IIdentifiable> creatures;
        public Engine()
        {
            this.creatures = new List<IIdentifiable>();
        }
        public void Run()
        {
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] inputArgs = input.Split();
                if (inputArgs.Length == 2)
                {
                    string model = inputArgs[0];
                    string id = inputArgs[1];

                    IIdentifiable robot = new Robot(model, id);
                    this.creatures.Add(robot);
                }
                else
                {
                    string name = inputArgs[0];
                    int age = int.Parse(inputArgs[1]);
                    string id = inputArgs[2];

                    IIdentifiable citizen = new Citizen(name, age, id);
                    this.creatures.Add(citizen);
                }
                input = Console.ReadLine();
            }
        }
    }
}