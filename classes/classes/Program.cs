using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Box
    {
        public double Length;
        public double Breadth;
        public double Height;

        public double Volume()
        {
            return (this.Length * this.Height * this.Breadth);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var box1 = new Box
            {
                Height = 20,
                Breadth = 10,
                Length = 45
            };

            Console.WriteLine("Volume of box1 is {0}", box1.Volume());

            var box2 = new Box
            {
                Height = 10,
                Breadth = 13,
                Length = 12
            };

            Console.WriteLine("Volume of box2 is {0}", box2.Volume());
        }
    }
}
