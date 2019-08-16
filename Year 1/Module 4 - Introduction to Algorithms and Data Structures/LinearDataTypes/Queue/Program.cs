using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularQueue<int> a = new CircularQueue<int>(4);
            a.Enqueue(1);
            a.Enqueue(2);
            var b = a.ToArray();
            System.Console.WriteLine(String.Join("; ", b));
        }
    }
}
