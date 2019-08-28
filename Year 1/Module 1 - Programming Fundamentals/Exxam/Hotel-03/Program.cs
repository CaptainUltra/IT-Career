using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var nights = int.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            double priceApartment = nights * 70;
            double pricePresApart = nights * 125;
            if (nights < 10)
            {
                if (type == "apartment") priceApartment = 0.7 * priceApartment;
                else pricePresApart = 0.9 * pricePresApart;
            }
            else if (nights <= 15)
            {
                if (type == "apartment") priceApartment = 0.65 * priceApartment;
                else pricePresApart = 0.85 * pricePresApart;
            }
            else
            {
                if (type == "apartment") priceApartment = 0.5 * priceApartment;
                else pricePresApart = 0.8 * pricePresApart;
            }
            if (type == "apartment") Console.WriteLine("{0:f2}", priceApartment);
            else Console.WriteLine("{0:f2}", pricePresApart);
        }
    }
}
