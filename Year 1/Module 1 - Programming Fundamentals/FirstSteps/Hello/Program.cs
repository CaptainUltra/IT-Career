using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello");
            for(int a=37; a<32000;a+=200)
            Console.Beep(a, 500);
            var leva = int.Parse(Console.ReadLine());
            var euro = leva / 1.95583;
            Console.WriteLine(euro);*/
            var chas = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());
            var pat = int.Parse(Console.ReadLine());
            min = min + pat;
            chas +=  min / 60;
            min = min % 60;
            if (chas >= 24) chas = 0;
            Console.Write(chas);
            Console.Write(":");
            Console.Write(min);
        }
    }
}
