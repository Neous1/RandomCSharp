﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }

        // overload == 
        public static bool operator ==(Box lhs, Box rhs)
        {
            bool status = lhs.length == rhs.length && lhs.height == rhs.height && lhs.breadth == rhs.height;
            return status;
        }

        public static bool operator !=(Box lhs, Box rhs)
        {
            bool status = lhs.length != rhs.length || lhs.height != rhs.height || lhs.breadth != rhs.breadth;
            return status;
        }

        public static bool operator < (Box lhs, Box rhs)
        {
            bool status = lhs.length < rhs.length && lhs.height < rhs.height && lhs.breadth < rhs.breadth;
            return status;
        }

        public static bool operator > (Box lhs, Box rhs)
        {
            bool status = lhs.length > rhs.length && lhs.height > rhs.height && lhs.breadth > rhs.breadth;
            return status;
        }

public static bool operator <= (Box lhs, Box rhs)
        {
            bool status = lhs.length <= rhs.length && lhs.height <= rhs.height && lhs.breadth <= rhs.breadth;
            return status;
        }

        public static bool operator >= (Box lhs, Box rhs)
        {
            bool status = lhs.length >= rhs.length && lhs.height >= rhs.height && lhs.breadth >= rhs.breadth;
            return status;
        }



        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", length, breadth, height);
        }


        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();
            Box Box2 = new Box();
            Box Box3 = new Box();

            double volume = 0.0;

            //box1 Specs
            Box1.setLength(6.0);
            Box1.setBreadth(7.0);
            Box1.setHeight(5.0);

            //box2 Specs
            Box2.setLength(12.0);
            Box2.setBreadth(13.0);
            Box2.setHeight(10.0);

            //volume of box 1
            volume = Box1.getVolume();
            Console.WriteLine("Volume of box1: {0}", volume);

            //volume of box 2
            volume = Box2.getVolume();
            Console.WriteLine("Volume of box1: {0}", volume);

            //Add two object as follows;
            Box3 = Box1 + Box2;

            //volume of box 3
            volume = Box3.getVolume();
            Console.WriteLine("Volume of box1: {0}", volume);

            //Comparing trhe boxes

            if (Box1 > Box2)
                Console.WriteLine("Box1 is greater than Box2");
            else
                Console.WriteLine("Box1 is not greater than Box2");


            if (Box1 < Box2)
                Console.WriteLine("Box1 is less than Box2");
            else
                Console.WriteLine("Box1 is not less than Box2");


            if (Box1 >= Box2)
                Console.WriteLine("Box1 is greater or equal to  Box2");
            else
                Console.WriteLine("Box1 is not less than Box2");


            if (Box1 < Box2)
                Console.WriteLine("Box1 is less than Box2");
            else
                Console.WriteLine("Box1 is not less than Box2");


            if (Box1 < Box2)
                Console.WriteLine("Box1 is less than Box2");
            else
                Console.WriteLine("Box1 is not less than Box2");


            if (Box1 < Box2)
                Console.WriteLine("Box1 is less than Box2");
            else
                Console.WriteLine("Box1 is not less than Box2");




                Console.ReadKey();
        }
    }
}
