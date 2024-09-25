using ConsoleDrawer;
using Solution.Shapes;

Shape q = new Quadrilateral(5, 10);
Shape s = new Square(5);
Shape t = new Triangle(10);
Shape c = new Circle(10);
c.Paint();
Console.ReadKey();