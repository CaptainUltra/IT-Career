using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double yeild = double.Parse(Console.ReadLine());
            int neededWine = int.Parse(Console.ReadLine());//nujni litri vino
            int workers = int.Parse(Console.ReadLine());
            double madeWine = ((area * yeild) * 0.4) / 2.5;//proizvedeno vino v litri
            if(madeWine<neededWine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededWine - madeWine)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(madeWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(madeWine - neededWine)} liters left -> {Math.Ceiling((madeWine-neededWine)/workers)} liters per person.");
            }
        }
    }
}
