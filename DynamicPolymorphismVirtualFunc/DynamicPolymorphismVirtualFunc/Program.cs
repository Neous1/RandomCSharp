using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    class Caller
    {
        public void CallArea(Shape sh)
        {
            int a;
            a = sh.Area();
            Console.WriteLine("Area: {0}", a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
