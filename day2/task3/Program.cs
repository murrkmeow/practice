namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значния ОТ и ДО подряд: ");
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
            else
            {
                Console.WriteLine("Число А > В");
            }
        }
    }
}
