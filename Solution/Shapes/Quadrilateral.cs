using ConsoleDrawer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Shapes
{
    internal class Quadrilateral : Shape
    {
        private int _width, _height;

        public Quadrilateral(int width, int height)
        {
            _width = width;
            _height = height;
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
    }
}
