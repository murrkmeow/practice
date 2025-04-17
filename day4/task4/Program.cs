namespace task4
{
    internal class Program
    {
        static double Min(double a, double b)
        {
            return a < b ? a : b;
        }

        static double Min(double a, double b, double c)
        {
            return Min(Min(a, b), c);
        }

        static void Main()
        {
            Console.Write("Введите значение a1: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b1: ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение a2: ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b2: ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение c2: ");
            double c2 = Convert.ToDouble(Console.ReadLine());

            double result = Min(a1, b1) * Min(a2, b2, c2);

            Console.WriteLine($"\nРезультат {Min(a1, b1)} * {Min(a2, b2, c2)}: {result:F2}");
        }
    }
}
