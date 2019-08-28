using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            var qty = double.Parse(Console.ReadLine());
            double price = 0;
            if(town=="sofia")
            {
                if (product == "coffee") price = 0.5;
                else if (product == "water") price = 0.8;
                else if (product == "beer") price = 1.20;
                else if (product == "sweets") price = 1.45;
                else price = 1.6;
            }
            if (town == "plovdiv")
            {
                if (product == "coffee") price = 0.4;
                else if (product == "water") price = 0.7;
                else if (product == "beer") price = 1.15;
                else if (product == "sweets") price = 1.30;
                else price = 1.55;
            }
            if (town == "sofia")
            {
                if (product == "coffee") price = 0.45;
                else if (product == "water") price = 0.7;
                else if (product == "beer") price = 1.10;
                else if (product == "sweets") price = 1.35;
                else price = 1.55;
            }
            Console.WriteLine(price*qty);
        }
    }
}
