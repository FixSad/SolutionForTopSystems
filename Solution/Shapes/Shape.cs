namespace Solution.Shapes
{
    abstract class Shape
    {
        public abstract double Area { get; }
        protected abstract double CalculateArea();
        public abstract void Paint();
    }
}
