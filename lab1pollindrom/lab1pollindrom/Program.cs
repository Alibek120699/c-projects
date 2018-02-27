using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab1pollindrom
{
    class Program
    {
        public static bool Checkpalindrom(string x)
        {
            int i = 0;
            int j = x.Length - 1;

            while (true)
            {
                if (i > j)
                {
                    return true;
                }
                if (char.ToLower(x[i]) != char.ToLower(x[j]))
                {
                    return false;
                }
                i++;
                j--;
            }
        }

        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] words = line.Split(' ');
            
            List<string> out1 = new List<string>();
            for(int i = 0; i < words.Length; i++)
            {
                

                if (Checkpalindrom(words[i]) == true)
                {
                    out1.Add(words[i] + " yes");
                    
                }
                else
                {
                    out1.Add(words[i] + " no");
                    
                }
                
            }
            File.WriteAllLines(@"C:\Users\HP\Desktop\c# projects\lab1pollindrom\lab1pollindrom\output.txt", out1);
        }
    }
}
