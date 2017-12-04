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
        protected double length;

        protected double width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        public double GetArea()
        {
            return length * width;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
