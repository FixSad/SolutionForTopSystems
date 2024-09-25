using ConsoleDrawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Shapes
{
    internal class Square : Shape
    {
        private double _side;


        public Square(double side) => _side = side;

        public override void Paint()
        {
            for (int i = 0; i < _side; i++)
            {
                for (int j = 0; j < _side; j++)
                {
                    DrawProvider.Drawer.Draw(i, j);
                }
                Console.WriteLine();
            }
        }
    }
}
