using System;

Console.WriteLine("Уравнение y=2x+3");
Equation equation = new Linear(2, 3);
equation.Root();
Console.WriteLine();
Console.WriteLine("Уравнение y^2-2y+1=0");
Equation equation1 = new Quadratic(1, -2, 1);
equation1.Root();
//Код абстрактного класса Equation:
public abstract class Equation
{
    public virtual void Root()
    {

    }
}
//Код производного класса Linear:Equation:
public class Linear : Equation
{
    private double a;
    private double b;
    public Linear(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public override void Root()
    {
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Бесконечное множество решений");
            }
            else
            {
                Console.WriteLine("Корней нет");
            }
        }
        else
        {
            double x = -b / a;
            Console.WriteLine("Корень данного уравнения: {0}", x);
        }
    }
}
//Код производного класса Quadratic:Equation:
public class Quadratic : Equation
{
    private double a;
    private double b;
    private double c;
    public Quadratic(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public override void Root()
    {
        double discr = b * b - 4 * a * c;
        if (discr > 0)
        {
            double x1 = (-b + Math.Sqrt(discr)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discr)) / (2 * a);
            Console.WriteLine("Корни данного уравнения: {0}, {1}", x1, x2);
        }
        else if (discr == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("Корень данного уравнения: {0}", x);
        }
        else
        {
            Console.WriteLine("Корней нет!");
        }
    }
}
