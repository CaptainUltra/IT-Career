// using System;
// using System.Linq;
// using System.Collections.Generic;

// namespace AnonymousThreat
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             List<string> words = Console.ReadLine().Split(' ').ToList();
//             string input = string.Empty;
//             while((input=Console.ReadLine())!="3:1")
//             {
//                 string[] tokens = input.Split(" ".ToCharArray()).ToArray();
//                 string command = tokens[0];
//                 switch(command)
//                 {
//                     case "merge": 
//                     int startIndex= int.Parse(tokens[1]);
//                     int endIndex= int.Parse(tokens[2]);
//                     if(endIndex<0 || startIndex > words.Count-1) continue;
//                     if(startIndex<0) startIndex = 0;
//                     if(endIndex> words.Count -1 ) endIndex = words.Count -1;
//                     words.Insert(startIndex, MegreElement(startIndex, endIndex, words)); 
//                     break;
//                     case "divide": 
//                     int index= int.Parse(tokens[1]);
//                     int partitions= int.Parse(tokens[2]);
//                     words.InsertRange(index, DivideElement(index, partitions, words));
//                     words.RemoveAt(index+partitions+1);                
//                     break;
//                 }
//             }
//             System.Console.WriteLine(String.Join(" ", words));
//         }

//         private static List<string> DivideElement(int index, int partitions, List<string> words)
//         {
//             string element = words[index];
//             int partLength = element.Length / partitions;
//             List<string> divided = new List<string>();
//             for(int i = 0; i< partitions;i++)
//             {
//                 if(i == partitions -1)
//                 {
//                     divided.Add(element);
//                 }
//                 string word = element.Substring(0, partLength);
//                 element = element.Substring(partLength);
//                 divided.Add(word);
//             }
//             return divided;
//         }

//         private static string MegreElement(int start, int end, List<string> words)
//         {
//             string concatWord = "";
//             for(int i = start; i <= end; i++)
//             {
//                 concatWord += words[start];
//                 words.RemoveAt(start);
//             }
//             return concatWord;
//         }
//     }
// }
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Numerics; 
using System.Text; 
using System.Threading.Tasks; 
namespace Anonymous_Threat 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        { 
            List<string> words = Console.ReadLine().Split().ToList(); 
            string input = string.Empty; 
            while ((input=Console.ReadLine())!="3:1") 
            { 
                string[] tokens = input.Split(" ".ToCharArray()).ToArray(); 
                string command = tokens[0]; 
                switch(command) 
                { 
                    case "merge": 
                        int startIndex = int.Parse(tokens[1]); 
                        int endIndex = int.Parse(tokens[2]); 

                        if (endIndex < 0 || startIndex > words.Count - 1) continue; 
                        if (startIndex < 0) startIndex = 0; 
                        if (endIndex > words.Count - 1) endIndex = words.Count - 1; 
                        string concatWord = ""; 
                        for (int i = startIndex; i <= endIndex; i++) 
                        { 
                            concatWord += words[startIndex]; 
                            words.RemoveAt(startIndex); 
                        } 
                        words.Insert(startIndex, concatWord); 

                        break; 
                    case "divide": 
                        int index = int.Parse(tokens[1]); 
                        int partitions = int.Parse(tokens[2]); 
                        string element = words[index]; 
                        int el=element.Length; 
                        int partLength = el / partitions; 
                        List < string > divided= new List<string>(); 
                        for (int i = 0; i < partitions; i++) 
                        { 
                            if (i == partitions - 1) 
                            { 
                                divided.Add(element); 
                                break; 
                            } 
                            string word = element.Substring(0, partLength); 
                            element = element.Substring(partLength); 
                            divided.Add(word); 
                        } 
                        words.RemoveAt(index); 
                        words.InsertRange(index, divided); 

                        break; 
                } 
            } 
            Console.WriteLine(string.Join(" ",words)); 
        } 
    } 
} 

