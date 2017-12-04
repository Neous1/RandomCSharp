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
            Console.WriteLine("printing int : {0}", i);
        }

        public void Print(double f)
        {
            Console.WriteLine("Printing float: {0}", f);
        }

        public void Print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Printdata();
            
            //call print to print integer
            p.Print(5);

            //call print to print float 
            p.Print(500.27);

            //call print to print string
            p.Print("Hellow SiliconRhode");


        }
    }
}
