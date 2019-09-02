using System;
using System.Collections.Generic;

namespace OddMatches
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string[] input = Console.ReadLine().Split(' ');
            var dic = new Dictionary<string, int>();
            int br = 0;
            List<string> result = new List<string>();
            for(int i = 0; i<input.Length;i++)
            {
                for(int j = 0; j< input.Length;j++)
                {
                    if(input[i].ToLower() == input[j].ToLower()) br++;
                }
                dic[input[i].ToLower()] = br;
                br = 0;
            }
            foreach(var word in dic)
            {
                if(word.Value %2 != 0) result.Add(word.Key);
            }*/
            //------
            var words = Console.ReadLine().ToLower().Split(new char[]{ ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var result = new Dictionary<string, int>();
            foreach(var word in words)
            {
                if(!result.ContainsKey(word))
                {
                    result[word] = 0;
                }
                result[word]++;
            }
            List<string> odd = new List<string>();
            foreach(var kvp in result)
            {
                if(kvp.Value %2 != 0) result.Add(kvp.Key);
            }
            System.Console.WriteLine(String.Join(", ", odd));
        }
    }
}
