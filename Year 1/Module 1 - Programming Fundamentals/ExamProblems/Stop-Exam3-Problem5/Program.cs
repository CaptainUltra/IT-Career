using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop_Exam3_Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var underscores = 2 * n + 1;
            Console.Write(new string('.', n + 1));
            Console.Write(new string('_', n * 2 + 1));
            Console.WriteLine(new string('.', n + 1));
            underscores -= 2;
            for (int i = 0;i<n;i++)
            {
                Console.Write(new string('.', n - i));
                Console.Write("//");
                Console.Write(new string('_', underscores));
                underscores += 2;
                Console.Write("\\\\");
                Console.Write(new string('.', n - i));
                Console.WriteLine();
            }
            //Mid
            Console.Write("//");
            Console.Write(new string('_', (underscores - 5) / 2));
            Console.Write("Stop!");
            Console.Write(new string('_', (underscores - 5) / 2));
            Console.Write("\\\\");
            Console.WriteLine();
            //Bottom
            for (int i = n; i > 0; i--)
            {
                Console.Write(new string('.', n - i));
                Console.Write("\\\\");
                Console.Write(new string('_', underscores));
                underscores -= 2;
                Console.Write("//");
                Console.Write(new string('.', n - i));
                Console.WriteLine();
            }
        }
    }
}
