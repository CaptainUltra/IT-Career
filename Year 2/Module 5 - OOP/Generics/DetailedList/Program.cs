using System;
using System.Collections.Generic;

namespace DetailedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new DetailedListClass<string>();
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                var cmdArgs = command.Split();
                var cmdType = cmdArgs[0];
                switch (cmdType)
                {
                    case "Add": Add(cmdArgs, list); break;
                    case "Remove": Remove(cmdArgs, list); break;
                    case "Contains": Contains(cmdArgs, list); break;
                    case "Swap": Swap(cmdArgs, list); break;
                    case "Greater": Greater(cmdArgs, list); break;
                    case "Max": Max(cmdArgs, list); break;
                    case "Min": Min(cmdArgs, list); break;
                    case "Sort": Sort(list); break;
                    case "Print": Print(cmdArgs, list); break;
                }

            }
        }
        public static void Add(string[] cmdArgs, DetailedListClass<string> list)
        {
            var item = cmdArgs[1];
            list.Add(item);
        }
        public static void Remove(string[] cmdArgs, DetailedListClass<string> list)
        {
            var index = int.Parse(cmdArgs[1]);
            var removed = list.Remove(index);
            System.Console.WriteLine($"Removed item: {removed}");
        }
        public static void Contains(string[] cmdArgs, DetailedListClass<string> list)
        {
            var item = cmdArgs[1];
            if(list.Contains(item))
            {
                System.Console.WriteLine("True");
            }
            else System.Console.WriteLine("False");
        }
        public static void Swap(string[] cmdArgs, DetailedListClass<string> list)
        {
            var index1 = int.Parse(cmdArgs[1]);
            var index2 = int.Parse(cmdArgs[2]);
            list.Swap(index1, index2);
        }
        public static void Greater(string[] cmdArgs, DetailedListClass<string> list)
        {
            var item = cmdArgs[1];
            System.Console.WriteLine(list.CountGreaterThan(item));
        }
        public static void Max(string[] cmdArgs, DetailedListClass<string> list)
        {
            System.Console.WriteLine(list.Max());
        }
        public static void Min(string[] cmdArgs, DetailedListClass<string> list)
        {
            System.Console.WriteLine(list.Min());
        }
        public static void Sort(DetailedListClass<string> list)
        {
            list.Sort();
        }
        public static void Print(string[] cmdArgs, DetailedListClass<string> list)
        {
            foreach (var item in list)
            {
                System.Console.WriteLine(item.ToString());
            }
        }
    }
}
