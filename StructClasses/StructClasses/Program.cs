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
            // create a reactangle struct
            Rectangle rect1;
            rect1.length = 200;
            rect1.width = 50;
            Console.WriteLine("Area of rect1: {0}", rect1.Area());

            Rectangle rect2 = new Rectangle(100, 40);
            //create a rectangle using constructor
            rect2 = rect1;
            rect1.length = 33;

            Console.WriteLine("rect2.length: {0}", rect1.length);
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
