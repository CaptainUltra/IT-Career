using System;
using System.Linq;
using System.Collections.Generic;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> players = new Dictionary<string, int>();
            var input = Console.ReadLine();
            while(input != "End of season")
            {
                var command = input.Split(" ").ToArray();
                if(!players.ContainsKey(command[0]))
                {
                    players.Add(command[0], 0);
                }
                players[command[0]] += int.Parse(command[2]);
                input = Console.ReadLine();
            }
            foreach (var kvp in players.OrderBy(x =>x.Key))
            {
                System.Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
            }
        }
    }
}

