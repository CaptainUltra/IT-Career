using System;
using System.Text;

namespace StringBuilderZad
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Test");
            sb.AppendLine("Gosho");
            sb.Append("Gosho");
            sb[4]= '!';
            System.Console.WriteLine(sb.ToString());
        }
    }
}
