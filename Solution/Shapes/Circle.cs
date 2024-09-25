using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Shapes
{
    internal class Circle : Shape
    {
        private int _radius;

        public Circle(int radius)
        {
            _radius = radius;

        }

        public override void Paint()
        {
            for (int y = 0; y <= 2 * _radius; y++)
            {
                for (int x = 0; x <= 2 * _radius; x++)
                {
                    double distance = Math.Sqrt(Math.Pow(x - _radius, 2) + Math.Pow(y - _radius, 2));
                    if (distance < _radius + 0.5 && distance > _radius - 0.5)
                    {
                        Console.SetCursorPosition(_radius + (x+1) - _radius, _radius + (y+1) - _radius);
                        Console.Write('*');
                    }
                }
            }
            Console.SetCursorPosition(0, 0);
        }
    }
}
