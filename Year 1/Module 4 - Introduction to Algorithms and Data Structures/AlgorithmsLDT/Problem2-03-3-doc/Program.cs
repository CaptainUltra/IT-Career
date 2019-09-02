using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2_03_3_doc
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            Queue<int> queue = new Queue<int> ();
            List<int> list = new List<int>();
            queue.Enqueue(n);
            while(count <= 50)
            {
                int tmp = queue.Dequeue();
                list.Add(tmp);
                queue.Enqueue(tmp + 1);
                count++;
                queue.Enqueue(tmp*2 + 1);
                count++;
                if(count == 50) break;
                queue.Enqueue(tmp + 2);
                count++;
            }
            while(queue.Count > 0 && list.Count < 50)
            {
                list.Add(queue.Dequeue());
            }
            System.Console.WriteLine(String.Join(", ", list));
        }
    }
}
