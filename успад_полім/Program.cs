public abstract class Shape
{
    public string Name { get; }

    protected Shape(string name)
    {
        Name = name;
    }

    public abstract double Area();
    public abstract double Perimeter();
}

public class Circle : Shape
{
    public double Radius { get; }

    public Circle(string name, double radius) : base(name)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

public class Square : Shape
{
    public double Side { get; }

    public Square(string name, double side) : base(name)
    {
        Side = side;
    }

    public override double Area()
    {
        return Side * Side;
    }

    public override double Perimeter()
    {
        return 4 * Side;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Circle circle1 = new Circle("Circle1", 5);
        Circle circle2 = new Circle("Circle2", 7);

        Square square1 = new Square("Square1", 4);
        Square square2 = new Square("Square2", 6);

        Shape[] shapes = { circle1, circle2, square1, square2 };

        Console.WriteLine("Details of all shapes:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.Name} - Area: {shape.Area()}, Perimeter: {shape.Perimeter()}");
        }

        double maxCircleArea = Math.Max(circle1.Area(), circle2.Area());
        double maxSquareArea = Math.Max(square1.Area(), square2.Area());

        Console.WriteLine($"\nLargest Circle Area: {maxCircleArea}");
        Console.WriteLine($"Largest Square Area: {maxSquareArea}");
    }
}
