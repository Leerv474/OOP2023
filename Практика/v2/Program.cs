using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hw_OOP
{
    abstract class Base
    {
        public virtual void Norm()
        {
            Console.WriteLine("Функция Норма");
        }
    }
    class Complex : Base
    {
        double a = 5, b = 2;
        public override void Norm()
        {
            a = Math.Pow(a, 2);
            b = Math.Pow(b, 2);
            Console.WriteLine($"1.Результат вычислений: {a}+{b}i^2;");
        }
    }
    class Vector : Base
    {
        double a = 2, b = 1, c = 9, d = 5, e = 3, f = 7, g = 6, h = 8, i = 0, j = 4,
        result;
        public override void Norm()
        {
            result = Math.Sqrt(a + b + c + d + e + f + g + h + i + j);
            Console.WriteLine($"2.Результат вычислений: {result};");
        }
    }
    class Matrix : Base
    {
        int d;
        int[,] matrix =
        {
{ 2 , 5 },
{ 10 , 4 }
}; public override void Norm()
        {
            d = matrix[0, 0] * matrix[0, 1] + matrix[1, 0] * matrix[1, 1];
            Console.WriteLine($"3.Результат вычислений: {d};");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex complex = new Complex();
            complex.Norm();
            Vector vector = new Vector();
            vector.Norm();
            Matrix matrix = new Matrix();
            matrix.Norm();
            Console.ReadLine();
        }
    }
}
