using System;
using System.Diagnostics;

namespace ex._4
{
    class Program
    {
        static void Output (double output)
        {
            Console.WriteLine($"Приближенное значение корня уравнения = {output}");
            Console.ReadKey();
            Process.GetCurrentProcess().Kill();
        }
        static void Method(double x0, double x1, double E)
        {
            double x2 = (x0 + x1) / 2;
            if (Math.Abs(x0 - x2) >= E)
            {
                if (Fx(x2) * Fx(x0) <= 0)
                {
                    Method(x0, x2, E);
                    Output(x2);
                }
                if (Fx(x2) * Fx(x1)<=0)
                {
                    Method(x1, x2, E);
                    Output(x2);
                }
            }
            Output(x2);
        }
        static double Fx(double x)
        {
            return (Math.Pow(x, 4) + 2 * Math.Pow(x, 3) - x - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите E");
            double E = double.Parse(Console.ReadLine());
            double x0 = 0;
            double x1 = 1;
            Method(x0, x1, E);
        }
    }
}
