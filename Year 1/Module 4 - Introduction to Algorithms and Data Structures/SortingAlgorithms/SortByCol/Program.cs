using System;
using System.Linq;

namespace SortByCol
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int select = input[2] -1;
            int[,] arr = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                var values = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = values[j];
                }
            }

            //Print
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    System.Console.Write(arr[i, j]);
                }
                System.Console.WriteLine();
            }

            //Sort
            for (int i = 0; i < rows; i++)
            {
                int key = arr[i, select];
                int j = i - 1;
                while (j >= 0 && arr[j, select] > key)
                {
                    for (int p = 0; p < cols; p++)
                    {
                        var tmp = arr[j + 1, p];
                        arr[j + 1, p] = arr[j, p];
                        arr[j, p] = tmp;
                    }
                    j--;
                }
                //arr[j + 1, select] = key;
            }

            //Print
            System.Console.WriteLine("Kraj: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    System.Console.Write(arr[i, j]);
                }
                System.Console.WriteLine();
            }
        }
    }
}
