using System;
using System.Collections.Generic;

namespace MoveDownRightMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());

            var numbers = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var line = Console.ReadLine().Split(' ');

                for (int j = 0; j < cols; j++)
                {
                    numbers[i, j] = int.Parse(line[j]);
                }
            }

            //Calculate sums
            var sums = new int[rows, cols];
            sums[0, 0] = numbers[0, 0];
            for (int i = 1; i < cols; i++)
            {
                sums[0, i] = sums[0, i - 1] + numbers[0, i];
            }
            for (int i = 1; i < rows; i++)
            {
                sums[i, 0] = sums[i - 1, 0] + numbers[i, 0];
            }

            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < cols; j++)
                {
                    sums[i, j] = Math.Max(sums[i - 1, j], sums[i, j - 1]) + numbers[i, j];
                }
            }

            System.Console.WriteLine(sums[rows - 1, cols - 1]);

            var result = new List<string>();
            result.Add($"[{rows - 1}, {cols - 1}]");

            var currentRow = rows - 1;
            var currentCol = cols - 1;
            while (currentRow != 0 || currentCol != 0)
            {
                var top = -1;
                if(currentRow -1 >= 0)
                {
                    top = sums[currentRow - 1, currentCol];
                }

                var left = -1;
                if(currentCol -1 >= 0)
                {
                    left = sums[currentRow, currentCol];
                }
                
                if (top > left)
                {
                    result.Add($"[{currentRow - 1}, {currentCol}]");
                    currentRow--;
                }
                else
                {
                    result.Add($"[{currentRow}, {currentCol - 1}]");
                    currentCol--;
                }

            }
            result.Reverse();
            System.Console.WriteLine(string.Join(" ", result));
        }
    }
}
