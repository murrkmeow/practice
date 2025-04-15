namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значния A и B подряд (A < B, 1 <= A,B <=100): ");
            int a = int.Parse(Console.ReadLine()!);
            int b = int.Parse(Console.ReadLine()!);
            
            if (a < b)
            {
                int sum = 0;
                for (int i = a; i <= b; i++)
                {
                    sum += i;
                }
                Console.WriteLine($"Сумма чисел от {a} до {b}: {sum}");
            }
            else if (b < a)
            {
                Console.WriteLine("Число А > В");
            }
            else
            {
                Console.WriteLine("Не соблюдено условие неравенств (1 <= A,B <=100).");
            }
        }
    }
}
