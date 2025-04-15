namespace task4
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y;

            if (x < 0.1)
            {
                y = Math.Sqrt(2 * Math.Pow(x, 2) + Math.Sin(x) + 1);
                Console.WriteLine($"Результат функции: y = {y}");
            }
            else if (x == 0.1)
            {
                y = 2 * x + Math.Exp(x);
                Console.WriteLine($"Результат функции: y = {y}");
            }
            else
            {
                Console.WriteLine("Функция не определена для значений x > 0.1.");
            }
        }
    }
}
