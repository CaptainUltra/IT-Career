using System;
using System.Linq;

namespace ReverseArrayString
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            string[] str = new string[n];
            for(int i=0;i<n;i++)
            {
                str[i] = Console.ReadLine();
            }
            //System.Console.WriteLine(sting.Join(' ',Aray.Reverse(str)));
            for(int i = 0; i < str.Length/2; i++)
            {
                string pom = str[i];
                str[i] =str[str.Length-1-i];
                str[str.Length-1-i] = pom;
            }
            System.Console.WriteLine(sting.Join(' ',str));
        }
    }
}
