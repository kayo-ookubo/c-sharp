namespace Section402
{
    abstract class PlaneFigure
    {
        protected double width;
        protected double height;

        protected PlaneFigure(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public abstract double Area
        { get; }
    }
}