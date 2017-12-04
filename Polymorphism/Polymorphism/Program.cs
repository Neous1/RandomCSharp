using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Printdata
    {
        void print(int i)
        {
            Console.WriteLine("printing int : {0}", i);
        }
        void print(double f)
        {
            Console.WriteLine("Printing float: {0}", f);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
