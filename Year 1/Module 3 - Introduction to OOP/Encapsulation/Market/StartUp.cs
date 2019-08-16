using System;
using System.Collections.Generic;
using System.Linq;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            var peopleInput = Console.ReadLine().Split(";");
            List<Person> people = new List<Person>();
            foreach (var person in peopleInput)
            {
                var command = person.Split("=");
                people.Add(Person(command[0],int.Parse(command[1])));
            }
            var productsInput = Console.ReadLine().Split(";");
            List<Product> products = new List<Product>();
            foreach (var product in productsInput)
            {
                var command = product.Split("=");
                products.Add(Product(command[0],int.Parse(command[1])));
            }
            List<string> output = new List<string>();
            var input = Console.ReadLine();
            while(input!="END")
            {
                cmdArgs = input.Split();
                var name = cmdArgs[0];
                var item = cmdArgs[1];
                var prod = products.Where(x => x.Name == item).FirstOrDefault();
                var peep = people.Where(x => x.Name == name).FirstOrDefault();
                if(peep.AddProduct(prod))
                {
                    output.Add($"{name} bought {item}");
                }
                else
                {
                    output.Add($"{name} can't afford {item}");
                }
            }
            System.Console.WriteLine(String.Join("\r\n", output));
            foreach (var person in people)
            {
                System.Console.WriteLine($"{person.Name} - {person.BagItems()}");
            }
        }
    }
}
