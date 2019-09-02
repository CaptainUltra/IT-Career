using System;
using System.Linq;

namespace LottaryTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dim = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[,] matrix = new int[dim[0], dim[1]]; 
            for(int i = 0; i<=dim[0]-1;i++)
            {
                int[] rowInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for(int j = 0; j <= dim[1]-1; j++)
                {
                    matrix[i,j] = rowInput[j]; 
                }
            }
            int sumDiag1 = 0, sumDiag2 = 0, sumEvenDiag = 0, sumEvenRow = 0, sumOddCol = 0, sumAbove = 0, sumUnder = 0;
            for(int i = 0; i<=dim[0]-1;i++)
            {
                for(int j = 0; j <= dim[1]-1; j++)
                {
                    if((j == 0 || j == dim[1]-1) && matrix[i, j] % 2 != 0)sumOddCol += matrix[i, j];
                    if((i == 0 || i == dim[0]-1) && matrix[i, j] % 2 == 0)sumEvenRow += matrix[i, j];
                    if(i == j)
                    {
                        sumDiag1 += matrix[i, j];
                        if(matrix[i, j] % 2 == 0) sumEvenDiag += matrix[i, j];
                    } 
                    if(i < j) sumAbove += matrix[i, j];
                    if(i > j) sumUnder += matrix[i, j];
                    if(i + j == dim[0] - 1) sumDiag2 += matrix[i, j];
                }
            }
            /*System.Console.WriteLine(sumAbove);
            System.Console.WriteLine(sumDiag1);
            System.Console.WriteLine(sumDiag2);
            System.Console.WriteLine(sumEvenDiag);
            System.Console.WriteLine(sumEvenRow);
            System.Console.WriteLine(sumOddCol);
            System.Console.WriteLine(sumUnder);*/
            if((sumDiag1 == sumDiag2) || (sumAbove % 2 == 0) || (sumUnder % 2 != 0))
            {
                System.Console.WriteLine("YES");
                double avg = (sumUnder + sumEvenDiag + sumEvenRow + sumOddCol) / 4.0;
                System.Console.WriteLine("{0:f2}", avg);
            }
            else System.Console.WriteLine("NO");
        }
    }
}
