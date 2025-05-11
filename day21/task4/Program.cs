using System;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main()
        {
            double a = -10;
            double b = 1;
            double step = 1.0;

            int count = (int)((b - a) / step) + 1;
            double[] results = new double[count];

            Parallel.For(0, count, i =>
            {
                double x = a + i * step;
                results[i] = Math.Atan(x);
                Console.WriteLine($"x = {x}, arctg(x) = {results[i]:F4}");
            });
        }
    }
}
