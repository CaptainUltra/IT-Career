using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            list.Add("pehso");
            list.Add("gosho");
            System.Console.WriteLine(list.IndexOf("gosho"));
            System.Console.WriteLine(list[0]);
            System.Console.WriteLine(list.Contains("pesho"));
        }
    }
}

