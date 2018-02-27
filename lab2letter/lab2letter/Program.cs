using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab2letter
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\HP\Desktop\c# projects\lab2letter\lab2letter\input.txt").ToUpper();

            int count = 0;
            List<string> letnum = new List<string>();
            int j = 65;// <= 90
            
            while (j <= 90)
            {
                for(int i = 0; i < text.Length; i++)
                {
                    if ((char)j == text[i])
                    {
                        count++;
                    }
                }
                letnum.Add((char)j + "   " + count.ToString());
                count = 0;
                j++;
            }

            File.WriteAllLines(@"C:\Users\HP\Desktop\c# projects\lab2letter\lab2letter\output.txt",letnum);
        }
    }
}
