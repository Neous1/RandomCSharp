using System;

namespace Classes
{
    class Car
    {
        //declare a variable for car

        public Car (string color)
        {
            this.Color = color;
        }

        //declare a describe() to specify a color.
        public string Describe()
        {
            return "This car is " + Color;
        }

        //declare a property Color to access variable car
        public string Color { get; set; }

        //private string color;

        //public string Color
        //{
        //    //the get method returns the variable
        //    get { return Color.ToUpper(); }
        //    //the set method assigns a value to the variabe color
        //    set
        //    {
        //        if (value == "Red")
        //            Color = value;
        //        else
        //            Console.WriteLine("This car can only be red!");
        //    }
        //}

        
    }
}