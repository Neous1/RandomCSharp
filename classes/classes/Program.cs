using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Animal
    {
        public string name;
        public string sound;

        public Animal()
        {
            name = "No Name";
            sound = "No Sound";
        }

        public Animal(string name = "No Name")
        {
            this.name = name;
            this.sound = "No Sound";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
