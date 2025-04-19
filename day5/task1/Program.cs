namespace task1
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Введите значение x: ");
                double x = double.Parse(Console.ReadLine()!);

                double denominatorA = 4 * x + 8;
                if (denominatorA == 0)
                    throw new DivideByZeroException("Знаменатель выражения a равен нулю.");

                double yA = 1 - 4 / denominatorA;
                Console.WriteLine($"Значение выражения a: {yA}");

                // Выражение b
                if (x == 1)
                    throw new DivideByZeroException("Знаменатель выражения b равен нулю.");

                double tanSquared = Math.Tan(x) * Math.Tan(x);
                double yB = tanSquared + 1 / (x - 1);
                Console.WriteLine($"Значение выражения b: {yB}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Ошибка деления на ноль: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка формата: введите корректное число.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
            }
        }
    }
}
