namespace Section402
{
    class Box : PlaneFigure
    {
        public Box(double width, double height) : base(width, height)
        {
        }

        public override double Area
        {
            get { return width * height; }
        }
    }
}