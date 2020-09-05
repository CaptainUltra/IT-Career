using System;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 14, 5, 12, 15, 7, 8, 9, 11, 10, 1 };
            int[] len = new int[numbers.Length];
            int[] prev = new int[numbers.Length];
            int maxSolution = 0;
            int maxSolutionIndex = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;
                for (int j = 0; j < i; j++)
                {
                    if(numbers[j] < numbers[i] && len[j] + 1 > len[i])
                    {
                        len[i] = len[j] + 1;
                        prev[i] = j;
                    }
                }
                if(len[i] > maxSolution)
                {
                    maxSolution = len[i];
                    maxSolutionIndex = i;
                }

            }

            /*Console.WriteLine("Arrays: ");
            Console.WriteLine(string.Join(' ', numbers));
            Console.WriteLine(string.Join(' ', len));
            Console.WriteLine(string.Join(' ', prev));*/

            Console.WriteLine();
            Console.WriteLine($"Max count: {maxSolution}");
            Console.WriteLine("Sequence: ");
            int index = maxSolutionIndex;
            while(index > -1)
            {
                Console.Write(numbers[index] + " ");
                index = prev[index];
            }
            Console.WriteLine();
        }
    }
}
