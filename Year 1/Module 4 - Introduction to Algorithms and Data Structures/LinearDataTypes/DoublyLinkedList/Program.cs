using System;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<string> list = new DoublyLinkedList<string>();
            list.AddFirst("One");
            list.AddFirst("Two");
            list.AddLast("Three");
            list.RemoveFirst();
            var arr = list.ToArray();
            System.Console.WriteLine(String.Join(' ', arr));
        }
    }
}
