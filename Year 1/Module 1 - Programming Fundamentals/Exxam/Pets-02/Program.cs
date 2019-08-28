using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var foodKgs = int.Parse(Console.ReadLine());
            var foodCat1 = double.Parse(Console.ReadLine());
            var foodCat2 = double.Parse(Console.ReadLine());
            var needed = (days * foodCat1) + (days * foodCat2);
            if(foodKgs>=needed)
            {
                Console.WriteLine("The cats are well fed.");
                Console.WriteLine("{0} kilos of food left.", Math.Ceiling(foodKgs-needed));
            }
            else
            {
                Console.WriteLine("The cats are hungry.");
                Console.WriteLine("{0} more kilos of food are needed.", Math.Floor(needed-foodKgs));
            }
        }
    }
}
