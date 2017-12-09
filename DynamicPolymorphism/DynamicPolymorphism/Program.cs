using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolymorphism
{
    class Program
    {
        abstract class Shape
        {
            public abstract int Area();
        }

        class Rectangle: Shape
       {
            private readonly int _length;
           private readonly int _width;

           public Rectangle(int a = 0, int b = 0)
           {
                _length = a;
               _width = b;
           }

           public override int Area()
           {
                Console.WriteLine("Rectangle class area:");
               return (_width * _length);
           }

       }
        static void Main(string[] args)
        {
            var rect = new Rectangle(10, 7);
            double a = rect.Area();
            Console.WriteLine("Area: {0}", a);
            Console.WriteLine();
        }
    }
}
