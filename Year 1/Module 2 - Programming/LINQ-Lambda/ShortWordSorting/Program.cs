using System;
using System.Linq;

namespace ShortWordSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine().Split(new char[] {'.', ',' ,':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?',' '})
            .Where(w => w.Length<5).Select(w => w.ToLower()).OrderBy(w => w).Distinct().ToList()
            .ForEach(System.Console.WriteLine);
        }
    }
}
