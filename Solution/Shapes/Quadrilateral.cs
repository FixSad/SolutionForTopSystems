using ConsoleDrawer;

namespace Solution.Shapes
{
    internal class Quadrilateral : Shape
    {
        private int _width, _height;

        public override double Area { get; }

        public Quadrilateral(int width, int height)
        {
            _width = width;
            _height = height;
            Area = CalculateArea();
        }

        public override void Paint()
        {
            for (int i = 0; i < _height; i++)
            {
                for (int j = 0; j < _width; j++)
                {
                    if (i == 0 || i == _height - 1 || j == 0 || j == _width - 1)
                        DrawProvider.Drawer.Draw(_height + j, _width + i);
                }
            }
        }

        protected override double CalculateArea() => _width * _height;
    }
}
