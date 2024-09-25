namespace Solution.Shapes
{
    abstract class Shape
    {
        public abstract double Area { get; }
        protected abstract double CalculateArea();
        public abstract void Paint();
        public override string ToString()
        {
            return $"Shape: {this.GetType().Name}, Area: {Area}";
        }
    }
}
