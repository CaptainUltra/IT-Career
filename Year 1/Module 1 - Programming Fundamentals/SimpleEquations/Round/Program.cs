using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Round
{
    class Program
    {
        static void Main(string[] args)
        {
            var up = Math.Ceiling(23.45);//24
            var down = Math.Floor(45.67);//45
            var m1 = Math.Round(1.234, 1);//1.2
            var m2 = Math.Round(1.234, 2);//1.23
            var m3 = Math.Round(1.234, 3);//1.234
        }
    }
}
