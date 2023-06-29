using System;
namespace Geometry
{
    abstract class Shape
    {
        public abstract double SurfaceArea();
    }
    class Cuboid : Shape
    {
        private double length;
        private double width;
        private double height;
        public Cuboid(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }
        public override double SurfaceArea()
        {
            return 2 * (length * width + length * height + width * height);
        }
    }
    class Tetrahedron : Shape
    {
        private double edgeLength;
        public Tetrahedron(double edgeLength)
        {
            this.edgeLength = edgeLength;
        }
        public override double SurfaceArea()
        {
            return Math.Sqrt(3) * Math.Pow(edgeLength, 2);
        }
    }
    class Sphere : Shape
    {
        private double radius;
        public Sphere(double radius)
        {
            this.radius = radius;
        }
        public override double SurfaceArea()
        {
            return 4 * Math.PI * Math.Pow(radius, 2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Cuboid(2, 3, 4);
            shapes[1] = new Tetrahedron(5);
            shapes[2] = new Sphere(6);
            foreach (Shape shape in shapes)
            {
                Console.WriteLine("Surface area: " + shape.SurfaceArea());
            }
        }
    }
}
