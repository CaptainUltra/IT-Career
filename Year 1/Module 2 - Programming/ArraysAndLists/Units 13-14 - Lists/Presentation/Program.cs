using System;
using System.Collections.Generic;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Peter");
            names.Add("Maria");
            names.Add("George");
            names.Add("Grzegorz");
            names.Add("Maria");
            names.Add("Maria");
            foreach( var name in names)
            {
                System.Console.WriteLine(name);
            }
            names.Remove("Maria");
            System.Console.WriteLine(String.Join(", ", names));

            //----

            var nums = new List<int> {10, 20, 30, 40, 50, 60};
            nums.RemoveAt(2);
            nums.Add(100);
            nums.Insert(0, -100);
            Console.WriteLine(String.Join(", ", nums));
        }
    }
}
