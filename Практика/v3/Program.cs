using System;
namespace Kul
{
    abstract class Curve
    {
        public abstract double CalculateY(double x);
    }
    class Line : Curve
    {
        private double a;
        private double b;
        public Line(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double CalculateY(double x)
        {
            return a * x + b;
        }
    }
    class Ellipse : Curve
    {
        private double a;
        private double b;
        public Ellipse(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double CalculateY(double x)
        {
            return Math.Sqrt(1 - (x * x / (a * a))) * b;
        }
    }
    class Hyperbola : Curve
    {
        private double a;
        private double b;
        public Hyperbola(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double CalculateY(double x)
        {
            return Math.Sqrt((x * x / (a * a)) - 1) * b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Curve line = new Line(2, 3);
            Curve ellipse = new Ellipse(5, 3);
            Curve hyperbola = new Hyperbola(4, 2);
            double x = 2;
            Console.WriteLine("Прямая: y = {0}", line.CalculateY(x));
            Console.WriteLine("Эллипс: y = {0}", ellipse.CalculateY(x));
            Console.WriteLine("Гипербола: y = {0}", hyperbola.CalculateY(x));
            Console.ReadKey();
        }
    }
}
