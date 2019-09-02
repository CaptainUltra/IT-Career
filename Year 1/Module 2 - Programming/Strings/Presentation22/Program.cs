using System;

namespace Presentation22
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();
            int counter = 0;
            int index = input.IndexOf(pattern);
            while (index != -1)
            {
                counter++;
                index = input.IndexOf(pattern, index + 1);
            }
            Console.WriteLine(counter);
            //-------------------------------------------
            string listOfBeers = "Amstel, Zagorka, Tuborg, Becks.";
            string[] beers = listOfBeers.Split(new char[] {' ', ',', '.'}, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Available beers are:");
            foreach (string beer in beers)
                Console.WriteLine(beer);
            //-------------------------------------------
        }
    }
}
