﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    public static class MyStaticClass
    {
        public static int myStaticVariable = 0;

        public static void MyStaticMethod()
        {
            Console.WriteLine("This is a static method.");
        }

        public static int MyStaticProperty { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(MyStaticClass.myStaticVariable);

            MyStaticClass.MyStaticMethod();

            MyStaticClass.MyStaticProperty = 100;

            Console.WriteLine(MyStaticClass.MyStaticProperty);
        }
    }
}
