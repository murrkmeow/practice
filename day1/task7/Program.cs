namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] testValues = { 1,0, 2.0, 3.0, 4.0, 5.0, 10.0, 543.0};

            foreach (double b in testValues)
            {
                double z1 = Math.Sqrt(2 * b + 2 * Math.Sqrt(Math.Pow(b, 2) - 4)) /
                   Math.Sqrt(Math.Pow(b, 2) - 4 + b + 2);
                double z2 = 1 / Math.Sqrt(b + 2);

                Console.WriteLine($"Для b = {b:F2},\nz1 = {z1:F5},\nz2 = {z2:F5}");
                Console.WriteLine(z1 == z2 ? "Результаты совпадают" : "Результаты не совпадают");
            }
        }
    }
}
