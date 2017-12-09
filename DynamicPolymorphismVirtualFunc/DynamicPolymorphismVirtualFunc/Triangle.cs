using System;

namespace DynamicPolymorphismVirtualFunc
{
    class Triangle : Shape
    {
        public Triangle(int a = 0, int b= 0): base(a, b) { }

        public override int Area()
        {
            Console.WriteLine("Triangle class area: ");
            return (width * height / 2);
        }
    }
}