using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("blue", 8);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("red", 5, 15);
        shapes.Add(s2);

        Circle s3 = new Circle("green", 4);
        shapes.Add(s3);

        int shapeNumber = 0;

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            shapeNumber += 1;

            Console.WriteLine($"Shape #{shapeNumber} is {color} and has an area of {area}.");
        }

    }
}