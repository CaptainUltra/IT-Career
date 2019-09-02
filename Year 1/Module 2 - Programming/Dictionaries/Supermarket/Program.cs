using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Dictionary<string, double[]>();
            string[] input = Console.ReadLine().Split(' ');
            while(input[0] !="stocked")
            {   
                shop[input[0]]= new [] {double.Parse(input[1]), double.Parse(input[2])};
                input = Console.ReadLine().Split(' ');
            }
            double sum = 0;
            foreach(var kvp in shop)
            {
                System.Console.WriteLine("{0}: ${1:f2} * {2} = ${3:f2}", kvp.Key, kvp.Value[0], kvp.Value[1], kvp.Value[0]* kvp.Value[1]);
                sum += kvp.Value[0]* kvp.Value[1];
            }
            System.Console.WriteLine(new string('-', 30));
            System.Console.WriteLine("Grand Total: ${0:f2}", sum);
        }
    }
}
