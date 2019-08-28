using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrs15min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrs = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            min += 15;
            if (min >= 60)
            {
                hrs++;
                min -= 60;
            }
            if (hrs >= 24) hrs = 0;
            if(min<10) Console.WriteLine(hrs + ":0" + min);
            else Console.WriteLine(hrs + ":" + min);
        }
    }
}
