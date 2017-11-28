namespace Classes
{
    class Car
    {
        //declare a variable for car
        private string color;

        public Car (string color)
        {
            this.color = color;
        }

        //declare a property Color to access variable car
        public string Color
        {
            get { return color; }
            set { color = value; }
        }



    }
}