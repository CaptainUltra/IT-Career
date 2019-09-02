using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(", ").ToList();
            var input = Console.ReadLine();
            while(input!="END")
            {
                switch(input)
                {
                    case "Add visitor":
                    names.Add(Console.ReadLine());
                    break;
                    case "Add visitor on position":
                    var visitor = Console.ReadLine();
                    var position = int.Parse(Console.ReadLine());
                    names.Insert(position, visitor);
                    break;
                    case "Remove visitor on position":
                    names.RemoveAt(int.Parse(Console.ReadLine()));
                    break;
                    case "Remove last visitor":
                    names.RemoveAt(names.Count - 1);
                    break;
                    case "Remove first visitor":
                    names.RemoveAt(0);
                    break;
                }
                input = Console.ReadLine();
            }
            System.Console.WriteLine(String.Join(", ", names));
        }
    }
}
