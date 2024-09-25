using Solution.Shapes;

List<Shape> shapes = new List<Shape> { new Quadrilateral(5, 10), 
                                     new Square(5), 
                                     new Triangle(7),
                                     new Circle(10) };
foreach (Shape shape in shapes)
{
    shape.Paint();
    Console.WriteLine("\n" + shape);
    Console.WriteLine("Tap to continue");
    Console.ReadKey();
    Console.Clear();
}