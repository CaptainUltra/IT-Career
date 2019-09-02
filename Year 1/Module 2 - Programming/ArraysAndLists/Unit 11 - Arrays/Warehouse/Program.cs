using System;
using System.Linq;

namespace Warehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ').ToArray();
            long[] qty = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            double[] price = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            string[] shopping = new string[products.Length];
            shopping[0] = Console.ReadLine();
            int i = 0;
            while(shopping[i] != "done" && i<shopping.Length)
            {   i++;
                shopping[i] = Console.ReadLine();
            }
            for(int k = 0; k<shopping.Length; k++)
            {
                for(int  j = 0; j<products.Length;j++)
                {
                    if(shopping[k] == products[j])
                    {
                        System.Console.WriteLine($"{products[k]} costs: {price[k]}; Available quantity: {qty[k]}");
                    }
                }
            }
        }
    }
}
