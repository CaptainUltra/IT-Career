using System;

namespace Box
{
    class Program
    {
        static void Main(string[] args)
        {
            var box = new Box<int>();

            box.Add(2);
            var element = box.Remove();
            System.Console.WriteLine(element);
            System.Console.WriteLine(box.Count);
        }

    }
}
