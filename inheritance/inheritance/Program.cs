using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    //Derived class

    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle();

            rectangle.setWidth(5);
            rectangle.setHeight(7);

            //Print the area of the object
            Console.WriteLine("Total area: {0}", rectangle.GetArea());

        }
    }
}
