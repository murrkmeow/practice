namespace task1
{
    internal class Program
    {
        static void Main()
        {
            double[] numbers = { 3.5, -2.1, 0.0, -7.8, 4.4, -1.3 };

            int negativeCount = 0;
            foreach (double num in numbers)
            {
                if (num < 0)
                {
                    negativeCount++;
                }
            }

            Console.WriteLine(string.Join("; ", numbers));

            Console.WriteLine("\nКоличество отрицательных элементов: " + negativeCount);
        }
    }
}
