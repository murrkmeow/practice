namespace task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = 0, B = 1;
            int M = 20;
            double H = (B - A) / M;

            Console.WriteLine("Таблица значений функции arctan(x):");
            for (int i = 0; i <= M; i++)
            {
                double x = A + i * H;
                double y = Math.Atan(x);
                Console.WriteLine($"x = {x:F4}, arctan(x) = {y:F4}");
            }
        }
    }
}
