using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;

namespace lab3farmngr
{

    class Program
    {
        public static void Draw(int index, List<FileSystemInfo> ff)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            for (int i = 0; i < ff.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                else
                    Console.BackgroundColor = ConsoleColor.Black;

                if (ff[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.Write(ff[i].Name);
                for (int j = 1; j < 40 - ff[i].Name.Length; ++j)
                {
                    Console.Write(' ');
                }
                Console.WriteLine('|');
            }
        }
        public static void OpenFile(int index, string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            DirectoryInfo[] fields = di.GetDirectories();
            FileInfo[] files = di.GetFiles();
            List<FileSystemInfo> ff = new List<FileSystemInfo>();
            ff.AddRange(fields);
            ff.AddRange(files);
            bool quit = false;

            while (!quit)
            {
                Draw(index, ff);
                ConsoleKeyInfo pressed = Console.ReadKey();
                switch (pressed.Key)
                {
                    case ConsoleKey.UpArrow:
                        index--;
                        Console.BackgroundColor = ConsoleColor.Black;
                        if (index < 0)
                        {
                            index = ff.Count - 1;

                        }
                        break;
                    case ConsoleKey.DownArrow:
                        index = (++index) % ff.Count;
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        if (ff[index].GetType() == typeof(DirectoryInfo))
                        {
                            try
                            {
                                OpenFile(0, ff[index].FullName);
                            }
                            catch (Exception)
                            {

                                Console.Clear();
                                //Console.Write("Exception!");
                            }

                        }

                        else if (ff[index].GetType() == typeof(FileInfo))
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            FileStream fs = new FileStream(ff[index].FullName, FileMode.Open, FileAccess.ReadWrite);
                            StreamReader sr = new StreamReader(fs);
                            try
                            {
                                Console.WriteLine(sr.ReadToEnd());
                                sr.Close();
                                fs.Close();
                                
                                bool ok = false;
                                while (!ok)
                                {
                                    ConsoleKeyInfo button = Console.ReadKey();
                                    if (button.Key == ConsoleKey.Q)
                                    {
                                        ok = false;
                                        break;
                                    }
                                    else
                                        Console.ReadKey();
                                }
                            }
                            catch (Exception)
                            {
                                Console.Clear();
                                //Console.Write("Exception!");
                            }
                        }
                        break;
                    case ConsoleKey.Escape:
                        quit = true;
                        break;
                    default:
                        break;
                }
            }

        }
        static void Main(string[] args)
        {
            string path = @"C:\Users\HP\Desktop\PP2\Lab2";
            //Draw(0, ff);
            OpenFile(0, path);
        }
    }
}