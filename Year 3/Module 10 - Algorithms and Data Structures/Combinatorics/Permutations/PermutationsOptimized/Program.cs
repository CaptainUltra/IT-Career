using System;

namespace PermutationsOptimized
{
    class Program
    {
        static int[] elements;
        static void Permute(int index)
        {
            if(index >= elements.Length)
            {
                Console.WriteLine(string.Join(" ", elements));
            }
            else
            {
                Permute(index + 1);
                for (int i = index + 1; i < elements.Length; i++)
                {
                    Swap(index, i);
                    Permute(index + 1);
                    Swap(index, i);
                }
            }
        }
        static void Swap(int first, int second)
        {
            var temp = elements[first];
            elements[first] = elements[second];
            elements[second] = temp;
        }
        static void Main(string[] args)
        {
            elements = new int[] {1, 2, 3};
            Permute(0);
        }
    }
}
