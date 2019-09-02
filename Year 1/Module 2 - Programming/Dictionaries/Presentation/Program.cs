using System;
using System.Collections.Generic;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();
            phonebook["John Smith"] = "+1-555-8976";
            phonebook["Lisa Smith"] = "+1-555-1234";
            phonebook["Sam Doe"] = "+1-555-5030";
            phonebook["Ivan"] = "+359-899-555-592";
            phonebook["Ivan"] = "+359-2-981-9819"; 
            phonebook.Remove("John Smith");
            foreach (var pair in phonebook)
            Console.WriteLine("{0} --> {1}", pair.Key, pair.Value);

            System.Console.WriteLine(phonebook.Count);

            var keys = phonebook.Keys;
            foreach(var key in keys)
            {
                System.Console.WriteLine(key);
            }

            var values = phonebook.Values;
            foreach(var value in values)
            {
                System.Console.WriteLine(value);
            }
            phonebook.Add("Pepi", "+354641");
            phonebook.Remove("Pepi");
            phonebook.Clear();
            bool containsKey = phonebook.ContainsKey("Ivan");
            bool containsValue = phonebook.ContainsValue("+324151");
            string result;
            bool success = phonebook.TryGetValue("Ivan", out result);
            System.Console.WriteLine(success);
            System.Console.WriteLine(result);

        }
    }
}
