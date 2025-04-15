namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество секунд с начала суток. n = ");
            int n = int.Parse(Console.ReadLine()!);

            int t = n / 3600;
            Console.WriteLine($"Количество часов с начала суток равно {1}", t);
        }
    }
}
