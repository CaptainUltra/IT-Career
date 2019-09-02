using System;
using System.Collections.Generic;

namespace N_P_element_03_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int count = 1;
            Queue<int> queue = new Queue<int> ();
            queue.Enqueue(n);
            while(count < p)
            {
                int tmp = queue.Dequeue();
                queue.Enqueue(tmp + 1);
                count++;
                if(count == p) break;
                queue.Enqueue(tmp*2);
                count++;
            }
            System.Console.WriteLine("Queue");
            foreach (var item in queue)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
