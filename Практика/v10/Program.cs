using System;
abstract class Shape
{
    public abstract double Volume();
}
class Cuboid : Shape
{
    private double length;
    private double width;
    private double height;
    public Cuboid(double l, double w, double h)
    {
        length = l;
        width = w;
        height = h;
    }
    public override double Volume()
    {
        return length * width * height;
    }
}
class Pyramid : Shape
{
    private double baseLength;
    private double baseWidth;
    private double height;
    public Pyramid(double bl, double bw, double h)
    {
        baseLength = bl;
        baseWidth = bw;
        height = h;
    }
    public override double Volume()
    {
        return (baseLength * baseWidth * height) / 3;
    }
}
class Tetrahedron : Shape
{
    private double sideLength;
    public Tetrahedron(double s)
    {
        sideLength = s;
    }
    public override double Volume()
    {
        return (Math.Pow(sideLength, 1 / 3) * 2) / 12;
    }
}
class Sphere : Shape
{
    private double radius;
    public Sphere(double r)
    {
        radius = r;
    }
    public override double Volume()
    {
        return (4 * Math.Pow(radius, 3) * Math.PI) / 3;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes = new Shape[4];
        shapes[0] = new Cuboid(2, 3, 4);
        shapes[1] = new Pyramid(3, 4, 5);
        shapes[2] = new Tetrahedron(6);
        shapes[3] = new Sphere(5);
        foreach (Shape shape in shapes)
        {
            Console.WriteLine("Объем фигуры : " + shape.Volume());
        }
        Console.ReadLine();
    }
}
