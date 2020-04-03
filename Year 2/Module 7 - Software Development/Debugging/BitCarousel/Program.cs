using System;

namespace BitCarousel
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = byte.Parse(Console.ReadLine());
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                string direction = Console.ReadLine();

                if (direction == "right")
                {
                    int rightMostBit = number & 1;
                    number >>= 1;
                    number |= (byte)(rightMostBit << 5);
                }
                else if (direction == "left")
                {
                    int leftMostBit = (number >> 5) & 1;
                    number <<= 1;
                    number |= (byte)leftMostBit;
                    number &= 63;
                }
            }
            //System.Console.WriteLine(Convert.ToString(number,2));
            Console.WriteLine(number);
        }
    }
}
