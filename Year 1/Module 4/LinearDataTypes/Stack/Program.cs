using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayStack<int> a = new ArrayStack<int>();
            a.Push(1);
            a.Push(2);
            System.Console.WriteLine(a.Pop());
            System.Console.WriteLine(a.Pop());
            System.Console.WriteLine(a.Pop());

            //System.Console.WriteLine(String.Join(", ", a.ToArray()));
        }
    }
}
