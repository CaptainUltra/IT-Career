using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket_Exam2_Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cena_zele = double.Parse(Console.ReadLine());
            var cena_plod = double.Parse(Console.ReadLine());
            var kg_zele = int.Parse(Console.ReadLine());
            var kg_plod = int.Parse(Console.ReadLine());
            Console.WriteLine(((cena_zele*kg_zele) + (cena_plod*kg_plod))/1.94);
        }
    }
}
