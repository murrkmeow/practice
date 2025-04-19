namespace task3
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите размер матрицы N (N < 10): ");
            int n = int.Parse(Console.ReadLine()!);

            if (n >= 10 || n <= 0)
            {
                Console.WriteLine("N должно быть от 1 до 9.");
                return;
            }

            Console.Write("Введите нижнюю границу диапазона (a): ");
            int a = int.Parse(Console.ReadLine()!);

            Console.Write("Введите верхнюю границу диапазона (b): ");
            int b = int.Parse(Console.ReadLine()!);

            if (a > b)
            {
                Console.WriteLine("Ошибка: a не может быть больше b.");
                return;
            }

            int[,] matrix = new int[n, n];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrix[i, j] = rand.Next(a, b + 1);

            Console.WriteLine("\nИсходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(matrix[i, j].ToString().PadLeft(5));
                Console.WriteLine();
            }

            int evenSum = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (matrix[i, j] % 2 == 0)
                        evenSum += matrix[i, j];

            Console.WriteLine($"\nСумма чётных элементов: {evenSum}");

            Console.WriteLine("\nКоличество положительных элементов в каждом столбце:");
            for (int j = 0; j < n; j++)
            {
                int positiveCount = 0;
                for (int i = 0; i < n; i++)
                {
                    if (matrix[i, j] > 0)
                        positiveCount++;
                }
                Console.WriteLine($"Столбец {j + 1}: {positiveCount}");
            }
        }
    }
}
