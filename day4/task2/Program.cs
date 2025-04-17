namespace task2
{
    internal class Program
    {
        static void InvDigits(ref int K)
        {
            int reversed = 0;
            while (K > 0)
            {
                reversed = reversed * 10 + K % 10;
                K /= 10;
            }
            K = reversed;
        }

        static void Main()
        {
            int[] numbers = new int[5];

            Console.WriteLine("Введите 5 целых положительных чисел:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Число {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine()!);
            }

            Console.WriteLine("\nЧисла с обратным порядком цифр:");
            for (int i = 0; i < 5; i++)
            {
                InvDigits(ref numbers[i]);
                Console.WriteLine($"Число {i + 1}: {numbers[i]}");
            }
        }
    }

}
