using System;
using System.Linq;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] items = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[items.Length];
            for(int r = 1; r <= k;r++)
            {
                int pom = items[items.Length-1];
                for(int i = items.Length - 1; i>0;i--)
                {
                    items[i]=items[i-1];
                }
                items[0]=pom;
                for(int i = 0; i<items.Length;i++)
                {
                    sum[i]+=items[i];
                }
            }
            System.Console.WriteLine(String.Join(' ', sum));
        }
    }
}
