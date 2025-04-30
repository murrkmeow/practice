namespace task2
{
    internal class Program
    {
        public delegate double MathFunction(double x);

        static void Main()
        {
            try
            {
                double x = 2.0;

                MathFunction functions = Function1;
                functions += Function2;
                functions += Function3;

                ExecuteFunctions(functions, x);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Общая ошибка: {ex.Message}");
            }
        }

        static void ExecuteFunctions(MathFunction functions, double x)
        {
            foreach (MathFunction func in functions.GetInvocationList())
            {
                try
                {
                    double result = func(x);
                    Console.WriteLine($"Результат: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при выполнении функции: {ex.Message}");
                }
            }
        }

        static double Function1(double x) => x * x;

        static double Function2(double x)
        {
            if (x <= 0)
                throw new ArgumentException("Логарифм определён только для x > 0");
            return Math.Log(x);
        }

        static double Function3(double x)
        {
            if (x == 0)
                throw new DivideByZeroException("Деление на ноль");
            return 1 / x;
        }
    }

}
