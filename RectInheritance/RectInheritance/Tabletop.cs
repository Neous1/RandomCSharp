﻿using System;

namespace RectInheritance
{
    class Tabletop: Rectangle
    {
        private double cost;

        public Tabletop(double l, double w): base(l, w)
        {
            
        }

        public double GetCost()
        {
            double cost;
            cost = GetArea() * 70;
            return cost;
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine("Cost : {0}", GetCost());
        }
    }
}