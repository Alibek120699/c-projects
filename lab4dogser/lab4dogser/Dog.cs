using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4dogser
{
    [Serializable]
    public class Dog
    {
        //[NonSerialized]
        private string name;
        private int age;
        private string color;

        public Dog(string name, int age, string color)
        {

        }

        public Dog()
        {
            name = "Rex";
            age = 7;
            color = "black";
        }

        public override string ToString()
        {
            return name + " " + age + " " + color;
        }
    }
}
