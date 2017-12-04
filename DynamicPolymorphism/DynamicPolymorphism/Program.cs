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
            public abstract int area();
        }

        class Rectangle: Shape
       {
            private readonly int length;
           private readonly int width;

           public Rectangle(int a = 0, int b = 0)
           {
                length = a;
               width = b;
           }

           public override int area()
           {
                Console.WriteLine("Rectangle class area:");
               return (width * length);
           }

       }
        static void Main(string[] args)
        {
            var rect = new Rectangle(10, 7);
            double a = rect.area();
            Console.WriteLine("Area: {0}", a);
            Console.WriteLine();
        }
    }
}
