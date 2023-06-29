
using System;

abstract class Progression
{
    protected double firstTerm; 
    protected double constant;  

    public Progression(double firstTerm, double constant)
    {
        this.firstTerm = firstTerm;
        this.constant = constant;
    }

    public abstract double SumProgression(int n);
}

class ArithmeticProgression : Progression
{
    public ArithmeticProgression(double firstTerm, double constant)
        : base(firstTerm, constant)
    {
    }

    public override double SumProgression(int n)
    {
        return (n / 2.0) * (2.0 * firstTerm + (n - 1) * constant);
    }
}

class GeometricProgression : Progression
{
    public GeometricProgression(double firstTerm, double constant)
        : base(firstTerm, constant)
    {
    }

    public override double SumProgression(int n)
    {
        return firstTerm * ((1 - Math.Pow(constant, n)) / (1 - constant));
    }
}

class Program
{
    static void Main(string[] args)
    {
        // первый элемент и шаг прогрессии
        ArithmeticProgression ap = new ArithmeticProgression(1.0, 2.0);
        GeometricProgression gp = new GeometricProgression(1.0, 2.0);

        Console.WriteLine("Сумма первых {0} членов арифметической прогрессии: {1}", 7, ap.SumProgression(7));
        Console.WriteLine("Сумма первых {0} членов геометрической прогрессии: {1}", 7, gp.SumProgression(7));
    }
}
