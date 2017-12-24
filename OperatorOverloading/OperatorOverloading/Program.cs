using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Box
    {
        private double length;
        private double breadth;
        private double height;

        public double getVolume()
        {
            return length * breadth * height;
        }

        public void setLength(double len)
        {
            length = len;
        }

        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public void setHeight(double hei)
        {
            height = hei;
        }

        //OVerload + operator to add two Box objects
        

        
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
