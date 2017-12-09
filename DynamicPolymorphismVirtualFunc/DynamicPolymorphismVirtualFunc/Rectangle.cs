using System;

namespace DynamicPolymorphismVirtualFunc
{
    public class Rectangle: Shape
    {
        public Rectangle( int a = 0, int b = 0): base(a, b)
        {
            
        }

        public override int Area()
        {
            Console.WriteLine("Rectangle class area:");
            return (width * height);
        }
    }
}