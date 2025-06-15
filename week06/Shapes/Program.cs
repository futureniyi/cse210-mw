using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of shapes
        List<Shape> shapes = new List<Shape>();

        // Create instances of different shapes
        Square s1 = new Square("Red", 5);
        Rectangle r1 = new Rectangle("Blue", 4, 6);
        Circle c1 = new Circle("Green", 3);

        // Add shapes to the list
        shapes.Add(s1);
        shapes.Add(r1);
        shapes.Add(c1);

        // Iterate and display area and color of each
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea():0.00}");
            Console.WriteLine();
        }
    }
}
