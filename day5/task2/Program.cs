namespace task2
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Введите значение x (x <= -1, x > 1): ");
                double x = double.Parse(Console.ReadLine()!);

                if (x <= -1 || x > 1)
                    throw new ArgumentOutOfRangeException(nameof(x), "Значение x выходит за допустимый диапазон.");

                double f;
                if (x > -1 && x < 1)
                {
                    if (x == 0)
                        throw new DivideByZeroException("Деление на ноль при вычислении f = cos(x) / x.");
                    f = Math.Cos(x) / x;
                }
                else
                {
                    f = 5 * x + 2;
                }

                Console.WriteLine($"Значение функции f: {f}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите корректное число через запятую.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
            }
        }
    }
}
