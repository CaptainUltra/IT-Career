using System;
using System.Linq;

namespace LongestSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols]; 
            int max = 0, posI = 0, posJ = 0;
            for(int i = 0; i<=rows-1;i++)
            {
                int[] rowInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for(int j = 0; j <= cols-1; j++)
                {
                    matrix[i,j] = rowInput[j]; 
                }
            }
            for(int i = 0; i<=rows-2;i++)
            {
                for(int j = 0; j<=cols-2;j++)
                {
                    if((matrix[i,j]+matrix[i+1,j]+matrix[i,j+1]+matrix[i+1, j+1]) > max)
                    {
                        max = matrix[i,j]+matrix[i+1,j]+matrix[i,j+1]+matrix[i+1, j+1];
                        posI = i;
                        posJ = j;
                    }
                }
            }
            System.Console.WriteLine("{0} {1}", matrix[posI, posJ], matrix[posI, posJ+1]);
            System.Console.WriteLine("{0} {1}", matrix[posI+1, posJ], matrix[posI+1, posJ+1]);
        }
    }
}
