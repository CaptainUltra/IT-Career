using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTitle
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            var sex = Console.ReadLine();
            if (sex == "f" && age >= 16) Console.WriteLine("Ms.");
            if (sex == "m" && age >= 16) Console.WriteLine("Mr.");
            if (sex == "f" && age < 16) Console.WriteLine("Miss");
            if (sex == "m" && age < 16) Console.WriteLine("Master");
        }
    }
}
