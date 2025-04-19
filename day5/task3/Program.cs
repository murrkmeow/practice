namespace task3
{
    internal class Program
    {
        static void DigitCountSum(int K, out int C, out int S)
        {
            if (K <= 0)
            {
                throw new ArgumentException("Число должно быть положительным.");
            }

            C = 0;
            S = 0;
            int temp = K;

            while (temp > 0)
            {
                int digit = temp % 10;
                S += digit;
                C++;
                temp /= 10;
            }

            if (C == 0)
            {
                throw new DivideByZeroException("Ошибка: количество цифр оказалось 0 (невозможно).");
            }
        }

        static void Main()
        {
            Console.WriteLine("Введите 5 положительных целых чисел:");

            for (int i = 1; i <= 5; i++)
            {
                try
                {
                    Console.Write($"Число {i}: ");
                    int number = int.Parse(Console.ReadLine()!);

                    int count, sum;
                    DigitCountSum(number, out count, out sum);
                    Console.WriteLine($"Цифр: {count}, Сумма цифр: {sum}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введено нечисловое значение.");
                    i--; 
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Ошибка деления на ноль: {ex.Message}");
                    i--;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Пользовательская ошибка: {ex.Message}");
                    i--;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
                    i--;
                }
            }

            Console.WriteLine("Работа программы завершена.");
        }
    }
}
