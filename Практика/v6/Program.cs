using System;

abstract class Shape
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
    public abstract void Print();
}

class Circle : Shape
{
    private double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }

    public override void Print()
    {
        Console.WriteLine("Circle: radius = " + radius);
        Console.WriteLine("Area = " + CalculateArea());
        Console.WriteLine("Perimeter = " + CalculatePerimeter());
    }
}

class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public override double CalculateArea()
    {
        return length * width;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (length + width);
    }

    public override void Print()
    {
        Console.WriteLine("Rectangle: length = " + length + ", width = " + width);
        Console.WriteLine("Area = " + CalculateArea());
        Console.WriteLine("Perimeter = " + CalculatePerimeter());
    }
}

class Trapezoid : Shape
{
    private double topLength;
    private double bottomLength;
    private double height;

    public Trapezoid(double tl, double bl, double h)
    {
        topLength = tl;
        bottomLength = bl;
        height = h;
    }

    public override double CalculateArea()
    {
        return (topLength + bottomLength) * height / 2;
    }

    public override double CalculatePerimeter()
    {
        return topLength + bottomLength + 2 * Math.Sqrt(height * height + Math.Pow((bottomLength - topLength) / 2, 2));
    }

    public override void Print()
    {
        Console.WriteLine("Trapezoid: top length = " + topLength + ", bottom length = " + bottomLength + ", height = " + height);
        Console.WriteLine("Area = " + CalculateArea());
        Console.WriteLine("Perimeter = " + CalculatePerimeter());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes = new Shape[3];
        shapes[0] = new Circle(5);
        shapes[1] = new Rectangle(3, 4);
        shapes[2] = new Trapezoid(3, 6, 4);

        foreach (Shape s in shapes)
        {
            s.Print();
            Console.WriteLine();
        }
    }
}
