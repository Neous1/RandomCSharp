using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolymorphismVirtualFunc
{
    class Shape
    {
        protected int width, height;

        public Shape(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }

        public virtual int Area()
        {
            Console.WriteLine("Parent class area: ");
            return 0;
        }
    }

    class Rectangle: Shape
    {
        public Rectangle( int a = 0, int b = 0): base(a, b)
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
