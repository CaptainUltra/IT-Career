using System;
using System.Linq;
using System.Collections.Generic;

namespace Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int indexD = input[input.Length-1];
            int[] originalField = input.Where((v, i) => i != input.Length-1).ToArray();
            int[] field = originalField;
            int steps = 0;
            while(field[indexD]!= 0)
            {
                field = Array.ConvertAll(field, x => x-1);
                if(field[indexD] == 0) break;
                steps++;
                while(field.Contains(0) &&  field[indexD]!=0)
                {
                    field[Array.IndexOf(field,0)] = originalField[Array.IndexOf(field,0)];
                }
                indexD = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine(String.Join(" ", field));
            System.Console.WriteLine(steps);
        }
    }
}
