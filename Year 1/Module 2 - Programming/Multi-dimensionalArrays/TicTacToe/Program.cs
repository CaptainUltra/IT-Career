using System;
using System.Linq;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matrix = new string[3, 3];
            bool flag = false;
            for(int i = 0; i<=2;i++)
            {
                string[] rowInput = Console.ReadLine().Split(' ').ToArray();
                for(int j = 0; j <= 2; j++)
                {
                    matrix[i,j] = rowInput[j]; 
                }
            }
            if(matrix[0,0] == matrix[0,1] && matrix[0,1] == matrix[0,3])
            {
                System.Console.WriteLine("The winner is: {0} ", matrix[0,0]);
                flag = true;
            }
            if(matrix[1,0] == matrix[1,1] && matrix[1,1] == matrix[1,3])
            {
                System.Console.WriteLine("The winner is: {0} ", matrix[1,0]);
                flag = true;
            }
            if(matrix[2,0] == matrix[2,1] && matrix[2,1] == matrix[2,2])
            {
                System.Console.WriteLine("The winner is: {0} ", matrix[2,0]);
                flag = true;
            }
            if(matrix[0,0] == matrix[1,0] && matrix[1,0] == matrix[2,0])
            {
                System.Console.WriteLine("The winner is: {0} ", matrix[0,0]);
                flag = true;
            }
            if(matrix[0,1] == matrix[1,1] && matrix[1,1] == matrix[2,1])
            {
                System.Console.WriteLine("The winner is: {0} ", matrix[0,1]);
                flag = true;
            }
            if(matrix[0,2] == matrix[1,2] && matrix[1,2] == matrix[2,2])
            {
                System.Console.WriteLine("The winner is: {0} ", matrix[0,2]);
                flag = true;
            }
            if(matrix[0,0] == matrix[1,1] && matrix[1,1] == matrix[2,2])
            {
                System.Console.WriteLine("The winner is: {0} ", matrix[0,0]);
                flag = true;
            }     
            if(matrix[2,0] == matrix[1,1] && matrix[1,1] == matrix[0,2])
            {
                System.Console.WriteLine("The winner is: {0} ", matrix[2,0]);
                flag = true;
            }
            if(!flag)System.Console.WriteLine("There is no winners");                        
        }
    }
}
