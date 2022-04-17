using System;

namespace _2._DelegatesAndLambdas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateAndPrint(3, 2, (int a, int b) => a - b);
        }

        delegate int MathOp(int x, int y);

        static void CalculateAndPrint(int x, int y, MathOp f)
        {
            Console.WriteLine(f(x, y));
        }
        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Subtract(int x, int y)
        {
            return x - y;
        }
    }
}
