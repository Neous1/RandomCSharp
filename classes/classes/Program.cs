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
            numOfAnimals++;
        }

        public Animal(string name = "No Name")
        {
            this.name = name;
            this.sound = "No Sound";
            numOfAnimals++;
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says{1}", name, sound);
        }

         static int numOfAnimals = 0;

        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
