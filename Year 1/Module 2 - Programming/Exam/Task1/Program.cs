using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int treadmilPrice = 5899;
            int crossPrice = 1699;
            int bikePrice = 1789;
            int dumbbelPrice = 579;
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                switch(input)
                {
                    case "treadmill": sum += treadmilPrice;break;
                    case "cross trainer":sum += crossPrice;break;
                    case "exercise bike":sum += bikePrice;break;
                    case "dumbbells":sum += dumbbelPrice;break;
                }
            }
            System.Console.WriteLine($"{sum:f2}");
        }
    }
}
