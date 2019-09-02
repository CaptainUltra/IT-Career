using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long secKey = int.Parse(Console.ReadLine());
            decimal totalLoss = 0;
            List<string> affectedSites = new List<string>();
            for(int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(' ').ToArray();
                totalLoss += long.Parse(data[1]) * decimal.Parse(data[2]);
                affectedSites.Add(data[0]);  
            }
            BigInteger secToken = BigInteger.Pow(secKey, n);
            System.Console.WriteLine(String.Join("\r\n", affectedSites));
            System.Console.WriteLine("Total Loss: {0:f20}", totalLoss);
            System.Console.WriteLine("Security token: {0}", secToken);
        }
    }
}
