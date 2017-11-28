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
    }
}