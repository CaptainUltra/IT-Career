using System;

namespace ChangeToOnlyLetters
{
    class Program
    {
        static void Main(string[] args) 
        { 
            string s = Console.ReadLine(); 
           
            int br = 0, i=0; 
            string rez = s; 
            char x = rez[0]; 
            while(i<rez.Length-1) 
            { 
                string num = ""; 
                br = 0; 
                while (x<='9'&&x>='0'&&i<rez.Length-1) 
                { 
                    br++; 
                    i++; 
                    num = num + x.ToString(); 
                    x = rez[i]; 
                } 
                
                 if(br>0&&i < rez.Length) 
                            if(!(x <= '9' && x >= '0')) 
                            {rez = rez.Replace(num, x.ToString()); 
                            i = i - br; 
                            } 
                if (i < rez.Length - 1) { i++; x = rez[i]; } 
            } 
            Console.WriteLine(rez); 
        } 
    }
}
