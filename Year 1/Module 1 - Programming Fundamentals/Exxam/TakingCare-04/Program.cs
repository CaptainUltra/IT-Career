using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakingCare_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var boughtFood = int.Parse(Console.ReadLine());
            boughtFood *= 1000;
            var days = int.Parse(Console.ReadLine());
            var eaten = 0;
            for(int i=0;i<=days-1;i++)
            {
                eaten += int.Parse(Console.ReadLine());
            }
            if(eaten<=boughtFood) Console.WriteLine("Food is enough! Leftovers: {0} grams", boughtFood-eaten);
            else Console.WriteLine("Food is not enough. You need {0} grams more.", eaten-boughtFood);
        }
    }
}
