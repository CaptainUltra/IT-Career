using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000_days
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = DateTime.Parse(Console.ReadLine());
            string format = "dd-MM-yyyy";
            var time = d.AddDays(999);
            Console.WriteLine(time.ToString(format));
        }
    }
}
