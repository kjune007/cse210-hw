using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square();
        Rectangle rectangle = new Rectangle();
        Circle circle = new Circle();

        List<Shape> shapes = new List<Shape>();

        square.SetSquare("Blue", 10);
        rectangle.SetRectangle("Red", 3, 7);
        circle.SetCircle("Greem", 10);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        Console.Clear();

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            Console.WriteLine($"{area}");
            Thread.Sleep(1000);
        }


    }
}