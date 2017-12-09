using System;

namespace PolymorphismApplication
{
    //partially implemented class Shape is created with 
    //used of the keyworld abstract.

    abstract class Shape
    {
        public abstract int Area();
    }

    class Rectangle: Shape
    {
        public int Length { get; }
        public int Width { get; }

        public Rectangle(int a = 0, int b = 0)
        {
            Length = a;
            Width = b;
        }

        public override int Area()
        {
            Console.WriteLine("Rectangle class area:");
            return (Width * Length);
        }
    }
    class Program
    {
        static void Main()
        {
            var rect = new Rectangle(10, 7);
            double a = rect.Area();
            Console.WriteLine("Area: {0}", a);
            Console.ReadKey();
        }
    }
}
