using System;

namespace patishta
{
    class Program
    {
        static int rows;
        static int cols;
        static int counter = 0;
        static char[,] lab =
            {
            {' ', ' ', ' ', '*', ' ', ' ', ' '},
            {'*', '*', '*', '*', ' ', '*', ' '},
            {' ', ' ', ' ', '*', ' ', ' ', ' '},
            {' ', '*', '*', '*', '*', '*', '*'},
            {' ', ' ', ' ', ' ', '*', ' ', ' '},
            };

        static void FindArea(int row, int col)
        {
            if ((col < 0) || (row < 0) || (col >= lab.GetLength(1)) || (row >= lab.GetLength(0)))
            {
                // We are out of the labyrinth
                return;
            }
            if (lab[row, col] != ' ')
            {
                // The current cell is not free
                return;
            }

            // Mark the current cell as visited
            char ch = 'V';
            lab[row, col] = ch;

            // Invoke recursion to explore all possible directions
            FindPath(row, col - 1); // left
            FindPath(row - 1, col); // up
            FindPath(row, col + 1); // right
            FindPath(row + 1, col); // down

            // Mark back the current cell as free
            lab[row, col] = ' ';
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

        static void Main()
        {
            rows = int.Parse(Console.ReadLine());
            cols = int.Parse(Console.ReadLine());
            //int areasFound = 0;
            List<Area> allAreas = new List<Area>();
            for (int i = 0; i < lab.GetLength(0); i++)
            {
                for (int j = 0; j < lab.GetLength(1); j++)
                {
                    if (lab[i, j] == ' ')
                    {
                        FindArea(i, j);
                        //areasFound++;
                        allAreas.Add(new Area(counter, i, j));
                        counter = 0;
                    }
                }
            }
        }
    }