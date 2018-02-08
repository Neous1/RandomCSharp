using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructClasses
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        struct Rectangle
        {
            public double length;
            public double width;

            //create a constructor
            public Rectangle(double l = 1, double w = 1)
            {
                length = l;
                width = w;
            }

            public double Area()
            {
                return length * width;
            }
            
        }
    }
}
