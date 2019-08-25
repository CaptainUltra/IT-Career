using System;

namespace FindPath
{
    class Program
    {
        static int pathCounter = 0;
        static char[,] lab =
            {
            {' ', ' ', ' ', '*', ' ', ' ', ' '},
            {'*', '*', ' ', '*', ' ', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', '*', '*', '*', '*', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', 'e'},
            };
        static char[] path = new char[lab.GetLength(0) * lab.GetLength(1)];
        static int position = 0;
        static void FindPath(int row, int col, char direction)
        {
            if ((col < 0) || (row < 0) || (col >= lab.GetLength(1)) || (row >= lab.GetLength(0)))
            {
                // We are out of the labyrinth
                return;
            }
            // Append the direction to the path
            path[position] = direction;
            position++;
            // Check if we have found the exit
            if (lab[row, col] == 'е')
            {
                PrintPath(path, 1, position - 1);
            }
            if (lab[row, col] == ' ')
            {
                // The current cell is free. Mark it as visited
                lab[row, col] = 's';
                // Invoke recursion to explore all possible directions
                FindPath(row, col - 1, 'L'); // left
                FindPath(row - 1, col, 'U'); // up
                FindPath(row, col + 1, 'R'); // right
                FindPath(row + 1, col, 'D'); // down                       
                lab[row, col] = ' '; // Mark back the current cell as free
            }
            // Remove the direction from the path
            position--;
        }
        static void PrintPath(char[] path, int startPos, int endPos)
        {
            Console.Write("Found path to the exit: ");
            for (int pos = startPos; pos <= endPos; pos++)
            {
                Console.Write(path[pos]);
            }
            Console.WriteLine();
        }
        private static void Print(char[,] lab)
        {
            for (int r = 0; r < lab.GetLength(0); r++)
            {
                for (int c = 0; c < lab.GetLength(1); c++)
                {
                    Console.Write("{0} ", lab[r, c]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            FindPath(0, 0, 'S');
        }
    }
}
