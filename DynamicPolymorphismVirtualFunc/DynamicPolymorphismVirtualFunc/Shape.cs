﻿using System;

namespace DynamicPolymorphismVirtualFunc
{
    public class Shape
    {
        protected int width, height;

        public Shape(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }

        public virtual int Area()
        {
            Console.WriteLine("Parent class area: ");
            return 0;
        }
    }
}