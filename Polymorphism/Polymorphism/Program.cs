using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Printdata
    {
        public void Print(int i)
        {
            Console.WriteLine("Printing int: {0}", 
                i);
        }

        public void Print(double f)
        {
            Console.WriteLine("Printing int: {0}",
                f);
        }

        public void Print(string s)
        {
            Console.WriteLine("Printing int: {0}",
                s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Printdata();
            p.Print(5);

            //print float
            p.Print(500.263);

            //print string
            p.Print("Hello c++");

            Console.ReadKey();

        }
    }
}
