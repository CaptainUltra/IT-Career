using System;
using System.Collections.Generic;

namespace TelephoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();
            string[] input = Console.ReadLine().Split(' ');
            string result;
            while(input[0]!="END")
            {
                switch(input[0])
                {
                    case "A": phonebook[input[1]] = input[2]; break;
                    case "S": 
                    {
                        if(phonebook.TryGetValue(input[1], out result))
                        {
                            System.Console.WriteLine("{0} -> {1}", input[1], result);
                        }
                        else
                        {
                            System.Console.WriteLine("Contact {0} does not exist.", input[1]);
                        }
                        break;
                    }
                }
                input = Console.ReadLine().Split(' ');
            }
        }
    }
}
