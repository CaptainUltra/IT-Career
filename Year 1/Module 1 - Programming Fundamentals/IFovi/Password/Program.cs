using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            if (a == "s3cr3t!P@ssw0rd") Console.WriteLine("Welcome");
            else Console.WriteLine("Wrong password!");
        }
    }
}
