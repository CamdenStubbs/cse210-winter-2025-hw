using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> list = new List<Shape>();
        Circle circle = new Circle("Orange", 14);
        Square square = new Square("Purple", 14);
        Rectangle rectangle = new Rectangle("Green", 10, 9);
        list.Add(circle);
        list.Add(square);
        list.Add(rectangle);
        foreach (Shape shape in list)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}