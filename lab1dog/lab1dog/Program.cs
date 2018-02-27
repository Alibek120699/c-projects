using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1dog
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Rex",4,"Black");
            Console.WriteLine(dog1);

            string line = Console.ReadLine();
            string[] prop = line.Split(' ');

            dog1.Name = prop[0];
            dog1.Age = int.Parse(prop[1]);
            dog1.Color = prop[2];

            //dog1.Name = Console.ReadLine();
            //dog1.Age = int.Parse(Console.ReadLine());
            //dog1.Color = Console.ReadLine();

            Console.Clear();
            Console.WriteLine(dog1);

            
            bool ok = false;
            while (!ok)
            {
                ConsoleKeyInfo increment = Console.ReadKey();
                switch (increment.Key)
                {
                    case ConsoleKey.UpArrow:
                        dog1.Age++;
                        Console.Clear();
                        Console.WriteLine(dog1);
                        break;
                    case ConsoleKey.DownArrow:
                        dog1.Age--;
                        Console.Clear();
                        Console.WriteLine(dog1);
                        break;
                    case ConsoleKey.Escape:
                        ok = true;
                        break;
                }
            }
            
        }
    }
}
