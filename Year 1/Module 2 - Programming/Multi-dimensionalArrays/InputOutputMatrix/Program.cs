using System;

namespace InputOutputMatrix
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
                for(int j = 0; j <= cols-1; j++)
                {
                    matrix[i,j] = int.Parse(Console.ReadLine());
                }
            }
            for(int i = 0; i<=rows-1;i++)
            {
                double avg = 0;
                for(int j = 0; j <= cols-1; j++)
                {
                    System.Console.Write("{0, 8}", matrix[i, j]);
                    avg += matrix[i, j];
                }
                avg/=cols;
                System.Console.WriteLine("{0, 8}", avg);
            }
        }
    }
}
