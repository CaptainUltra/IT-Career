using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairingTheTiles_Exam3_Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var l = double.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var o = double.Parse(Console.ReadLine());
            var areaTile = w * l;
            var area = n * n;
            var areaBench = m * o;
            var numberTiles = (area - areaBench) / areaTile;
            var time = numberTiles*0.2;
            Console.WriteLine(numberTiles);
            Console.WriteLine(time);
        }
    }
}
