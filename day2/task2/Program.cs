namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа подряд:");
            int a = int.Parse(Console.ReadLine()!);
            int b = int.Parse(Console.ReadLine()!);
            int c = int.Parse(Console.ReadLine()!);

            if (a == b && a == c)
                Console.WriteLine("Все числа равны.");
            else if (a == b || a == c || a == b)
                Console.WriteLine("Одна пара чисел равна.");
            else
                Console.WriteLine("Ни одно число не равно другому.");
        }
    }
}
