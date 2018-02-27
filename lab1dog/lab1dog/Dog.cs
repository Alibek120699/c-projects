using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1dog
{
    class Dog
    {
        private string name;
        private int age;
        private string color;

        public Dog()
        {
            name = "Rex";
            age = 4;
            color = "black";
        }

        public Dog(string name, int age, string color)
        {
            this.name = name;
            this.age = age;
            this.color = color;
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 1)
                    age = 1;
                else
                    age = value;
            }
        }

        public string Color
        {
            get { return color; }
            set
            {
                color = value;
            }
        }

        public override string ToString()
        {
            return name + " " + age + " " + color;
        }
    }
}
