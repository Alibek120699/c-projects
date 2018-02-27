using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab4dogser
{
    class Program
    {
        static void f1()
        {
            FileStream fs = new FileStream(@"dog.xml", FileMode.Create, FileAccess.Write);

            XmlSerializer xs = new XmlSerializer(typeof(Dog));

            Dog dog1 = new Dog();
            xs.Serialize(fs, dog1);

            fs.Close();

            Console.WriteLine("Is serialised by xml");
        }

        static void f2()
        {
            FileStream fs = new FileStream(@"dog.xml",FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(Dog));

            Dog dog1 = xs.Deserialize(fs) as Dog;

            Console.WriteLine(dog1);

            fs.Close();
        }

        static void f3()
        {
            FileStream fs = new FileStream(@"dog.bin", FileMode.Create, FileAccess.Write);

            BinaryFormatter bf = new BinaryFormatter();
            Dog dog1 = new Dog();
            bf.Serialize(fs, dog1);

            fs.Close();
            Console.WriteLine("Is serialized by binary formatter");
        }

        static void f4()
        {
            FileStream fs = new FileStream(@"dog.bin", FileMode.Open, FileAccess.Read);

            BinaryFormatter bf = new BinaryFormatter();
            Dog dog1 = bf.Deserialize(fs) as Dog;

            Console.WriteLine(dog1);
            fs.Close();

        }
        static void Main(string[] args)
        {
            //f1();
            //f2();
            f3();
            f4();
        }
    }
}
