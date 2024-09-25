using ConsoleDrawer;

namespace Solution.Shapes
{
    internal class Triangle : Shape
    {
        private int _height;
        public override double Area { get; }

        public Triangle(int height)
        {
            _height = height;
            Area = CalculateArea();
        }

        public override void Paint()
        {
            for (int i = 0; i < _height; i++)
            {
                for (int j = 0; j <= i * 2; j++)
                {
                    DrawProvider.Drawer.Draw(j, i + 1);
                }
                Console.WriteLine();
            }
        }

        protected override double CalculateArea() => (_height * (_height - 1)) / 2;
    }
}
