using System;
using System.Linq;
using System.Collections.Generic;

namespace RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Dictionary<string, List<int>> customerFlights = new Dictionary<string, List<int>>();
            while(input != "I believe I can fly!")
            {
                string[] command = input.Split(" ").ToArray();
                if(command[1]=="=")
                {
                    var value = customerFlights[command[2]];
                    customerFlights[command[0]].Clear();
                    foreach (var flight in value)
                    {
                        customerFlights[command[0]].Add(flight);
                    }
                }  
                else
                {
                    if(!customerFlights.ContainsKey(command[0]))
                    customerFlights.Add(command[0], new List<int>());
                    List<int> flights = command.Where((v, i) => i != 0).Select(int.Parse).ToList();
                    var flightsOrdered = flights.OrderBy(x=>x);
                    string customer = command[0];
                    foreach (var flight in flightsOrdered)
                    {
                        customerFlights[customer].Add(flight);
                    }
                }
                input = Console.ReadLine();
            }
            var customerFlightsOrdered = customerFlights.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key);
            foreach (var kvp in customerFlightsOrdered)
            {
                var flights = kvp.Value.OrderBy(x=>x);
                System.Console.WriteLine("#{0} ::: {1}", kvp.Key, String.Join(", ",flights));
            }
        }
    }
}
