using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exxam
{
    class Program
    {
        static void Main(string[] args)
        {
            var skiers = int.Parse(Console.ReadLine());
            var jackets = int.Parse(Console.ReadLine());
            var helmets = int.Parse(Console.ReadLine());
            var shoes = int.Parse(Console.ReadLine());
            var all = skiers * ((jackets * 120) + (helmets * 75) + (shoes * 299.9));
            var dds = all * 1.2;
            Console.WriteLine("{0:f2}", dds);
        }
    }
}
