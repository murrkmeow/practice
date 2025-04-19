namespace task5
{
    internal class Program
    {
        static long Factorial(int k)
        {
            if (k <= 1)
                return 1;
            return k * Factorial(k - 1);
        }

        static double ComputeF(int n)
        {
            int value = n + 5;
            long factorial = Factorial(value);
            return 1.0 / factorial;
        }

        static void Main()
        {
            Console.Write("Введите значение n: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
            {
                double result = ComputeF(n);
                Console.WriteLine($"f({n}) = 1 / ({n}+5)! = {result}");
            }
            else
            {
                Console.WriteLine("Ошибка ввода. Введите целое неотрицательное число.");
            }
        }
    }
}
