using System;
using System.Linq;

namespace Action
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Array.ForEach(lines,element => System.Console.WriteLine("Sir " + element));
        }
    }
}
