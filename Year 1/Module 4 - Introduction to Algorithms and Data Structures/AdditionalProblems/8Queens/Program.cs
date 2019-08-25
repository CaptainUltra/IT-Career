using System;
using System.Collections.Generic;

namespace _8Queens
{
    public class EightQueens
    {
        const int Size = 8;
        static bool[,] chessboard = new bool[Size, Size];
        static int solutionsFound = 0;
        static HashSet<int> attackedRows = new HashSet<int>();
        static HashSet<int> attackedCols = new HashSet<int>();
        static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
        static HashSet<int> attackedRightDiagonals = new HashSet<int>();
        public static void PutQueens(int row)
        {
            if(row == Size)
            {
                PrintSolution();
            }
            else
            {
                for(int col = 0; col < Size; col++)
                {
                    if(CanPlaceQueen(row, col))
                    {
                        MarkAllAttackedPositions(row, col);
                        PutQueens(row+1);
                        UnmarkAllAttackedPositions(row, col);
                    }
                }
            }
        }
        static bool CanPlaceQueen(int row, int col)
        {
            var positionOccupied = attackedRows.Contains(row) || attackedCols.Contains(col) || attackedLeftDiagonals.Contains(col - row) || attackedRightDiagonals.Contains(row + col);
            return !positionOccupied;
        }
        static void MarkAllAttackedPositions(int row, int col)
        {
            attackedRows.Add(row);
            attackedCols.Add(col);
            attackedLeftDiagonals.Add(col - row);
            attackedRightDiagonals.Add(row + col);
            chessboard[row, col] = true;
        }
        static void UnmarkAllAttackedPositions(int row, int col)
        {
            attackedRows.Remove(row);
            attackedCols.Remove(col);
            attackedLeftDiagonals.Remove(col - row);
            attackedRightDiagonals.Remove(col + row);
            chessboard[row,col] = false;
        }
        static void PrintSolution()
        {
            for(int row = 0; row < Size; row++)
            {
                for(int col = 0; col < Size; col++)
                {
                    if(chessboard[row,col] == true) System.Console.Write("*");
                    else System.Console.Write("-");
                    System.Console.Write(" ");
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
            solutionsFound++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EightQueens.PutQueens(0);
            //System.Console.WriteLine(EightQueens.);
        }
    }
}
