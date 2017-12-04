using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectInheritance
{
    class Rectangle
    {
        //member variables
        protected double Length;

        protected double Width;

        public Rectangle(double l, double w)
        {
            Length = l;
            Width = w;
        }

        public double GetArea()
        {
            return Length * Width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", Length);
            Console.WriteLine("Width: {0}", Width);
            Console.WriteLine("Area: {0}", GetArea());

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
