using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec1 = int.Parse(Console.ReadLine());
            int sec2 = int.Parse(Console.ReadLine());
            int sec3 = int.Parse(Console.ReadLine());
            int sec = sec1 + sec2 + sec3;
            int min = sec / 60;
            sec = sec % 60;
            if (sec < 10) Console.WriteLine($"{min}:0{sec}");
            else Console.WriteLine($"{min}:{sec}");
        }
    }
}
