using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Box
    {
        public double length;
        public double breadth;
        public double height;

        public double volume()
        {
            return (this.length * this.height * this.breadth);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var box1 = new Box
            {
                height = 20,
                breadth = 10,
                length = 45
            };

            Console.WriteLine("Volume of box1 is {0}", box1.volume());

            var box2 = new Box
            {
                height = 10,
                breadth = 13,
                length = 12
            };

            Console.WriteLine("Volume of box2 is {0}", box2.volume());
        }
    }
}
