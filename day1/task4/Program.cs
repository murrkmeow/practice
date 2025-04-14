namespace task4
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите сторону a: ");
            double a = double.Parse(Console.ReadLine()!.Replace('.', ','));

            Console.Write("Введите сторону b: ");
            double b = double.Parse(Console.ReadLine()!.Replace('.', ','));

            double P = 2 * (a + b); 
            double S = a * b;       
            double d = Math.Sqrt(a * a + b * b);

            Console.WriteLine("Периметр: {0:0.00}", P);
            Console.WriteLine("Площадь: {0:0.00}", S);
            Console.WriteLine("Диагональ: {0:0.00}", d);

            Console.ReadKey();
        }
    }
}
