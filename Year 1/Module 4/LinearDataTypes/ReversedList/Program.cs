using System;

namespace ReversedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ReversedList<string> list = new ReversedList<string>();
            list.Add("One");
            list.Add("Two");
            System.Console.WriteLine(list[0]);
        }
    }
}
