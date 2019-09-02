using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var k = numbers.Length / 4;
            var firstPartUpperRow = numbers.Take(k).Reverse().ToArray();
            var secondPartUpperRow = numbers.Reverse().Take(k).ToArray();
            var upperRow = firstPartUpperRow.Concat(secondPartUpperRow).ToArray();
            var lowerRow = numbers.Skip(k).Take(2*k).ToArray();
            int[] result = new int[k*2];
            for(int i = 0; i<k*2;i++)
            {
                result[i]=(upperRow[i]+lowerRow[i]);
            }
            System.Console.WriteLine(String.Join(" ", result));
        }
    }
}
