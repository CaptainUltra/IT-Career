using System;
using System.Linq;

namespace UserComparer
{
    public class Program
    {
        static void Main(string[] args)
        {
            var comparer = new IntComparator();
            int[] numbers = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
            Array.Sort(numbers, comparer);
            System.Console.WriteLine(String.Join(' ', numbers));
        }
    }

}
