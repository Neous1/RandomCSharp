using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Tabletop(4.5, 7.5);
            t.Display();
            Console.ReadLine();
        }
    }
}
