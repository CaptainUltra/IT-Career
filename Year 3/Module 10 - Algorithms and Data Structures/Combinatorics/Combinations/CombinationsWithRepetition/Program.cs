using System;

namespace CombinationsWithRepetition
{
    class Program
    {
        static int k;
        static int[] numbers;
        static int[] combinations;
        static void Combine(int index, int start)
        {
            if (index >= k)
            {
                Console.WriteLine(string.Join(", ", combinations));
                return;
            }
            for (int i = start; i < numbers.Length; i++)
            {
                combinations[index] = numbers[i];
                Combine(index + 1, i);
            }
        }
        static void Main(string[] args)
        {
            numbers = new int[] { 1, 2, 3, 4 };
            k = 2;
            combinations = new int[k];
            Combine(0, 0);
        }
    }
}
