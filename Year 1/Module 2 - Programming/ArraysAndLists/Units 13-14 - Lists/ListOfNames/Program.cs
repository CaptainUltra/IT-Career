using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfNames
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> names = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.None).ToList();
            List<string> names = Console.ReadLine().Split(',').ToList();
            for(int i=0;i<names.Count; i++)
                System.Console.WriteLine(String.Join(' ', names[i].Split(' ').Reverse()));
        }
    }
}
