namespace Section402
{
    class Triangle : PlaneFigure
    {
        public Triangle(double width, double height) : base(width, height)
        {
        }

        public override double Area
        {
            get { return width * height / 2;}
        }
    }
}