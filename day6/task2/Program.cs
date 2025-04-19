namespace task2
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = new int[100];
            Random rand = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(-50, 51);
            }

            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
            }

            int[] result = new int[100];
            int countOnes = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == max)
                {
                    result[i] = 1;
                    countOnes++;
                }
                else
                {
                    result[i] = 0;
                }
            }

            Console.WriteLine("Исходный массив:");
            Console.WriteLine(string.Join(", ", numbers));

            Console.WriteLine($"\nМаксимум: {max}");
            Console.WriteLine($"Количество единиц в новой последовательности: {countOnes}");

            Console.WriteLine("\nНовая последовательность:");
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
