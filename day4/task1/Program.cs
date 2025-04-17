namespace task1
{
    internal class Program
    {
        static double CalculateFx(double x, double a, double b)
        {
            if (Math.Abs(x) < 1)
            {
                return Math.Tan(b - x);
            }
            else if (Math.Abs(x) >= 1 && Math.Abs(x) <= 5)
            {
                return a / Math.Sqrt(x * x);
            }
            else // Math.Abs(x) > 5
            {
                return 1 / Math.Sqrt(x * x + a + Math.Cos(b * x));
            }
        }

        static void Main()
        {
            Console.Write("Введите значение a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите шаг h: ");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nТаблица значений функции:");
            Console.WriteLine("{0,-10}{1,-10}", "x", "f(x)");
            Console.WriteLine(new string('-', 20));

            for (double x = a; x <= b; x += h)
            {
                try
                {
                    double y = CalculateFx(x, a, b);
                    Console.WriteLine("{0,-10:F2}{1,-10:F2}", x, y);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("{0,-10:F2}{1,-10}", x, "деление на 0!");
                }
            }
        }
    }
}
