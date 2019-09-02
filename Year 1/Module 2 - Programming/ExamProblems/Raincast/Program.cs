/* using System;
using System.Linq;
using System.Collections.Generic;

namespace Raincast
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Raincast = new List<string>();
            string t="",s="",f = "";
            string input =Console.ReadLine();
            while(input!="Davai Emo")
            {
                string[] command = input.Split(new char[] {':'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if((command[0]=="Type") && (command[1]=="Normal" || command[1]=="Warning" || command[1]=="Danger"))
                {
                    t = command[1];
                    t = t.Remove(0,1);
                    input = Console.ReadLine();
                    while(input!="Davai Emo")
                    {
                        if((command[0]=="Source") && (command[1].All(x => char.IsLetterOrDigit(x))))
                        {
                            s = command[1];
                            input = Console.ReadLine();
                            while(input!="Davai Emo")
                            {
                                if((command[0]=="Forecast"))
                                {
                                    f = command[1];
                                    break;
                                }
                                input = Console.ReadLine();
                            }
                            break;
                        }
                        input = Console.ReadLine();
                    }
                }
                if (t != "" && s != "" && f != "") Raincast.Add("(" + t + ")" + f + " ~" + s); 
                t = ""; s = ""; f = ""; 
               input = Console.ReadLine(); 
            }
            Console.WriteLine(String.Join("\r\n", Raincast)); 
        }
    }
}
 */
 using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Numerics; 
using System.Text; 
using System.Threading.Tasks; 

namespace Raincast 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        { 
            List<string> output = new List<string>(); 
            string t = "", s = "", f = ""; 


            string input = Console.ReadLine(); 
            while (input != "Davai Emo") 
            { 
                List<string> info = input.Split(':').ToList(); 
                if ((info[0] == "Type") && (info[1] == " Normal" || info[1] == " Warning" || info[1] == " Danger")) 
                { 
                    t = info[1]; 
                    t = t.Remove(0,1); 
                    input = Console.ReadLine(); 
                    while ((input != "Davai Emo")&&(s=="")) 
                    { 
                        info = input.Split(':').ToList(); 
                        if ((info[0] == "Source"))//&&(info[1].All(x=>char.IsLetterOrDigit(x)))) 
                        { 
                            s = info[1]; 
                            input = Console.ReadLine(); 
                            while (input != "Davai Emo"&&f=="") 
                            { 
                                info = input.Split(':').ToList(); 
                                if ((info[0] == "Forecast") && !info[1].Contains('?') && !info[1].Contains('!')&& !info[1].Contains('.')&& !info[1].Contains(',')) 
                                { 
                                    f = info[1]; 
                                    break; 
                                } 
                                input = Console.ReadLine(); 
                            } 
                            break;   
                        } 
                        input = Console.ReadLine(); 
                         

                    } 
                } 
                if (t != "" && s != "" && f != "") output.Add("(" + t + ")" + f + " ~" + s); 
                t = ""; s = ""; f = ""; 
               input = Console.ReadLine(); 
            } 
             
            Console.WriteLine(String.Join("\r\n", output)); 
        } 
        } 
} 
