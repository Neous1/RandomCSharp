using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //array is a class, supriiiise.
            string[] names = new string[2];
            names [0] = "John Doe";
            names[1] = "Jane Doe";

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
