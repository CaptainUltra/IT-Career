using System;
using System.Linq;

namespace AnonymousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] placeholders = Console.ReadLine().Split(new char[] {'{','}'}).ToArray();
            string find = "";
            int indexL = 0, indexR = 0;
            for(int i = 0; i< input.Length;i++)
            {
                if((input[i]>='A' && input[i]<='Z') || (input[i]>='a' && input[i]<='z'))
                {
                    find += input[i];
                    System.Console.WriteLine(input[i]);
                    System.Console.WriteLine("Find I: {0}; {1}", find, i);
                    for(int j = input.Length-1-i; j>i; j--)
                    {
                        System.Console.WriteLine("Find J: {0}; {1}", find, j);
                        if(find == input.Substring(j, find.Length))
                        {
                            //System.Console.WriteLine("Yes");
                            System.Console.WriteLine("{0} -> {1}", i, find);
                            System.Console.WriteLine("{0} -> {1}", j, input.Substring(j, find.Length));
                            indexL=i;
                            indexR=j;
                            break;
                        }
                    }
                }
                else 
                {
                    find="";
                }
            }
            System.Console.WriteLine("Index L: {0}", indexL);
            System.Console.WriteLine("Index R: {0}", indexR);
        }
    }
}
