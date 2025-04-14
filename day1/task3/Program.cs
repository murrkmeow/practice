namespace task3
{
    internal class Program
    {
        static void Main()
        {
            double x = 6.4;

            double numerator1 = Math.Exp(x);
            double denominator1 = Math.Cos(Math.Sqrt(x - 1));

            double numerator2 = 2 * Math.Atan(Math.Pow(x, 2));
            double denominator2 = 1 - x;

            double y = (numerator1 / denominator1) + (numerator2 / denominator2);

            Console.WriteLine("y = {0:F4}", y);
        }
    }
}
