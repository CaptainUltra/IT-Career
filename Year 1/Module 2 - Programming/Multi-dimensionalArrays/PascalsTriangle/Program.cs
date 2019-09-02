using System;

namespace PascalsTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            long[][] traingle = new long[h+1][];//Jagged Array
            for(int i = 0; i<h;i++)// for each row
            {
                traingle[i] = new long[i+1];//new row number +1
            }
            traingle[0][0]=1;
            for(int i = 0; i < h - 1 ;i++)//<h if second way
            {
                for(int j = 0; j<=i; j++)
                {
                    traingle[i+1][j] += traingle[i][j];
                    traingle[i+1][j+1] += traingle[i][j];
                }
                //second way
                /*traingle[i][0]=1;
                for(int j = 1; j<i;j++)
                {
                    traingle[i][j] = traingle[i-1][j-1]+ traingle[i-1][j];  
                }
                traingle[i][i] = 1;*/
            }
            for(int i = 0; i<h;i++)
            {
                for(int j = 0; j<=i;j++)
                {
                    System.Console.Write(" {0}", traingle[i][j]);
                }
                System.Console.WriteLine();
            }
        }
    }
}
