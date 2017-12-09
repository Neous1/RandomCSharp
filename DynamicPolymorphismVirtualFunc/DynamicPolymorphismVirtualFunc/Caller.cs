using System;

namespace DynamicPolymorphismVirtualFunc
{
    public class Caller
    {
        public void CallArea(Shape sh)
        {
            var a = sh.Area();
            Console.WriteLine("Area: {0}", a);
        }
    }
}