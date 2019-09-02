using System;
using System.Linq;

namespace AverageRows
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            for(int i = 0; i<=rows-1;i++)
            {
                int[] rowInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for(int j = 0; j <= cols-1; j++)
                {
                    matrix[i,j] = rowInput[j]; 
                }
            }
            int[] min = new int[cols];
            for(int i = 0; i<=cols-1;i++)
            {
                min[i] = matrix[0, i];
                for(int j = 1; j<=rows-1;j++)
                {
                    if(matrix[j,i]<min[i]) min[i] = matrix[j, i];
                }
            }
            for(int i = 0; i<=rows-1;i++)
            {
                for(int j = 0; j <= cols-1; j++)
                {
                    System.Console.Write("{0, 5}", matrix[i, j]);
                }
                System.Console.WriteLine();
            }
            for(int j = 0; j <= cols-1; j++)
                {
                    System.Console.Write("{0, 5}", min[j]);
                }
            System.Console.WriteLine();
        }
    }
}
