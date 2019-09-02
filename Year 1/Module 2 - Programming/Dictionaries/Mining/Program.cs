using System;
using System.Collections.Generic;

namespace Mining
{
    class Program
    {
        static void Main(string[] args)
        {
            var mine = new Dictionary<string, int>();
            string input = Console.ReadLine();
            while(input !="stop")
            {   
                int ammount = int.Parse(Console.ReadLine());
                if(!mine.ContainsKey(input))
                {
                    mine[input] = 0;
                }
                mine[input] += ammount;
                input = Console.ReadLine();
            }
            foreach(var kvp in mine)
            {
                System.Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
