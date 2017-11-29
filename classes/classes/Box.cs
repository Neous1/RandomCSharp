namespace classes
{
    class Box
    {
        public double Length;
        public double Breadth;
        public double Height;

        public double Volume()
        {
            return (this.Length * this.Height * this.Breadth);
        }
    }
}