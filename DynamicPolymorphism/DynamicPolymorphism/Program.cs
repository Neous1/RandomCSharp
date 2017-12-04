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

       public class Rectangle: Shape
       {
            private int length;
           private int width;

           public Rectangle(int a = 0, int b = 0)
           {
                length = a;
               width = b;
           }

           public override int area()
           {
                Console.WriteLine("Rectangle class are:");
               return (width * length);
           }

       }
        static void Main(string[] args)
        {
        }
    }
}
