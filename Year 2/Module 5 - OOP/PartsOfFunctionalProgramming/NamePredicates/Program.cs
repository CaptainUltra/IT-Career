using System;
using System.Linq;

namespace NamePredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            names = names.Where(x => x.Length <= n).ToArray();
            System.Console.WriteLine(String.Join(' ', names));
        }
    }
}
