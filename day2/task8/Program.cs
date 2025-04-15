namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа k и n подряд (1 <= k, n <= 100):");
            int k = int.Parse(Console.ReadLine()!);
            int n = int.Parse(Console.ReadLine()!);

            if (1 <= k && n <= 100)
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(k);
            }
        }
    }
}
