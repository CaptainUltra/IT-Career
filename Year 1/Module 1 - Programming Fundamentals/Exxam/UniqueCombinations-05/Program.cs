using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueCombinations_05
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            for(int i=1;i<9;i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    if (i + j == 9)
                    {
                        if(b>a)
                        {
                            if (a < 122) a++;
                            if (b < 122) b++;
                            Console.Write((char)a);
                            Console.Write((char)b);
                            Console.Write(i);
                            Console.Write(j);
                            Console.Write(" ");
                        }
                        else if(a<b)
                        {
                            if (a < 122) a++;
                            if (b < 122) b++;
                            Console.Write((char)b);
                            Console.Write((char)a);
                            Console.Write(i);
                            Console.Write(j);
                            Console.Write(" ");
                        }
                    }
                }
            }
        }
    }
}
