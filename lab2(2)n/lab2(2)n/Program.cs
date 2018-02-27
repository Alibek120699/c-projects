using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab2_2_n
{
    class Program
    {
        public static bool Check(int n)
        {
            while (true)
            {
                if (n == 1)
                    return true;
                if (n % 2 != 0)
                    return false;
                else
                    n=n/2;
            }
        }
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\HP\Desktop\c# projects\lab2(2)n\lab2(2)n\input.txt");
            string[] numbers = text.Split(' ', '\n', '\t');

            List<string> out1 = new List<string>();
            for(int i = 0; i < numbers.Length; i++)
            {
                if(Check(int.Parse(numbers[i]))== true)
                {
                    out1.Add((numbers[i]) + "    yes");
                }
                else
                {
                    out1.Add(numbers[i] + "   no");
                }
            }

            File.WriteAllLines(@"C:\Users\HP\Desktop\c# projects\lab2(2)n\lab2(2)n\output.txt", out1);
        }
    }
}
