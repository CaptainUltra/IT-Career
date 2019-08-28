using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidPasswordGenerator_Exam1_Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            for(int i = 1; i<=n;i++)
            {
                for(int j = 1;j<=n;j++)
                {
                    for(char k = 'a'; k<'a'+l;k++ )
                    {
                        for(char p='a';p<'a'+l;p++)
                        {
                            for (int t = Math.Max(i,j)+1; t <= n; t++)
                            {
                                Console.Write(i);
                                Console.Write(j);
                                Console.Write(k);
                                Console.Write(p);
                                Console.Write(t);
                                Console.Write(" ");
                            }
                        }
                    }
                }
            }
        }
    }
}
