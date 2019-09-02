using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems_03_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 6
            /*var a = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int x = int.Parse(Console.ReadLine());
            var result = new List<int>();
            if(a.Contains(x))
            {
                a.Remove(x);
            }
            else
            {
                //a.Add(x);
                //a.Sort();
                
                int i = 0;
                for(; i< a.Count && a[i]< x; i++)
                {
                    result.Add(a[i]);
                }
                result.Add(x);
                for(; i < a.Count(); i++)
                {
                    result.Add(a[i]);
                }
            }
            System.Console.WriteLine(String.Join(", ", result));*/

            //Problem 7
            /*List<int> input = new List<int>();
            int p;
            while(int.TryParse(Console.ReadLine(), out p))
            {
                input.Add(p);
            }
            System.Console.WriteLine("Sum = {0}", input.Sum());
            System.Console.WriteLine("Avg = {0}", input.Average());*/

            //Problem 10
            /*var a = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int i = 0;
            while(i<a.Count)
            {
                int x = a[i];
                int br = 1;
                int j = i + 1;
                while(j < a.Count)
                {
                    if(a[j] == x)
                    {
                        br++;
                    }
                    j++;
                }
                if(br % 2 != 0)
                {
                    while(a.Contains(x))
                    {
                        a.Remove(x);
                    }
                }
                else
                {
                    i += br;
                }
            }
            System.Console.WriteLine(String.Join(", ", a));*/

            //Problem 11
            /*Dictionary<int,int> d = new Dictionary<int, int>();
            var a = Console.ReadLine().Split(new char[]{' ', ' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            foreach (var item in a)
            {
                if(d.ContainsKey(item))
                {
                    d[item] += 1;
                }
                else
                {
                    d.Add(item, 1);
                }
            }
            foreach (var item in d)
            {
                System.Console.WriteLine("{0} - {1} times", item.Key, item.Value);
            }*/
        }
    }
}
