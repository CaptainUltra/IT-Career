using System;
using System.Collections.Generic;
using System.Linq;

namespace MagnetTape
{
    class Programme
    {
        public int Number { get; private set; }
        public int Length { get; private set; }
        public double Probability { get; private set; }
        public double ImportanceCoefficient => this.Probability / this.Length;
        public Programme(int number, int lenght, double probability)
        {
            this.Number = number;
            this.Length = lenght;
            this.Probability = probability;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            var programmes = new List<Programme>()
            {
                new Programme(1, 1, 0.3),
                new Programme(2, 3, 0.1),
                new Programme(3, 2, 0.5),
                new Programme(4, 4, 0.2)
            };

            programmes = programmes.OrderByDescending(x => x.ImportanceCoefficient).ToList();

            foreach (var item in programmes)
            {
                Console.Write(item.Number + " ");
            }
            Console.WriteLine();
        }
    }
}
