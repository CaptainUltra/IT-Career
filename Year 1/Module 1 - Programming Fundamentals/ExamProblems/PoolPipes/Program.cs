using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double hrs = double.Parse(Console.ReadLine());
            double p1_filled = p1 * hrs;
            double p2_filled = p2 * hrs;
            double filled = p1_filled + p2_filled;
            if (filled <= volume) Console.WriteLine($"The pool is {Math.Floor((filled / volume) * 100)}% full. Pipe 1: {Math.Floor((p1_filled / filled) * 100)}%. Pipe 2: {Math.Floor((p2_filled / filled) * 100)}%.");
            else Console.WriteLine($"For {hrs} hours the pool overflows with {filled-volume} liters.");
        }
    }
}
