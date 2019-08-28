using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueCombinations_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            for(int i=a;i<=122;i++)
            {
                for(int j=b;j<=122;j++)
                {
                    for(int x=1;x<=9;x++)
                    {
                        for(int y=1;y<=9;y++)
                        {
                            if (j>i && x + y == 9)
                            {
                                Console.Write((char)i);
                                Console.Write((char)j);
                                Console.Write(x);
                                Console.Write(y);
                                Console.Write(" ");
                            }
                        }
                    }
                }
            }
        }
    }
}
