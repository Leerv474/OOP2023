using System;
using System.Collections.Generic;

namespace Homework
{
    abstract class Shape
    {
        public abstract double Square();
    }
    class Rectangle : Shape
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }
        public override double Square()
        {
            return A * B;
        }
    }
    class Circle : Shape
    {
        public double R { get; private set; }
        public Circle(double r)
        {
            R = r;
        }
        public override double Square()
        {
            return 2 * Math.PI * Math.Pow(R, 2);
        }
    }
    class RightTriangle : Shape
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public RightTriangle(double a, double b)
        {
            A = a;
            B = b;
        }
        public override double Square()
        {
            return (A * B) / 2;
        }
    }
    class Trapeze : Shape
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double H { get; private set; }
        public Trapeze(double a, double b, double h)
        {
            A = a;
            B = b;
            H = h;
        }
        public override double Square()
        {
            return ((A + B) * H) / 2;
        }
    }
    class Programm
    {
        public static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Rectangle(5, 5));
            shapes.Add(new Circle(2));
            shapes.Add(new RightTriangle(5, 8));
            shapes.Add(new Trapeze(2, 3, 6));
            int index = 0;
            foreach (var tmp in shapes)
            {
                Console.WriteLine("{0}) {1} with area =  { 2:f2} ", index++, tmp.GetType().Name, tmp.Square());
            }
        }
    }
}
