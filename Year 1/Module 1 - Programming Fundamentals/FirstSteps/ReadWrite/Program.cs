using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var age = Console.ReadLine();
            Console.WriteLine("Hello, " + name + ". You are" + age + "yo.");
            Console.WriteLine("Hello, {0}. You are {1} yo.", name, age);
            Console.WriteLine($"Hello, {name}. You are {age} yo.");
        }
    }
}
