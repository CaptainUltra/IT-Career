using System;

namespace Variations
{
    class Program
    {
        static int k;
        static int[] numbers;
        static bool[] used;
        static int[] variations;
        public static void Generate(int index)
        {
            if (index >= k)
            {
                Console.WriteLine(string.Join(" ", variations));
                return;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    variations[index] = numbers[i];
                    Generate(index + 1);
                    used[i] = false;
                }
            }

        }
        static void Main(string[] args)
        {
            numbers = new int[] { 1, 2, 3, 4 };
            used = new bool[numbers.Length];
            k = 2;
            variations = new int[k];
            Generate(0);
        }
    }
}
