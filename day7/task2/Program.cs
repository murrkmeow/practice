namespace task2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine()!;

            string result = "";

            foreach (char c in input)
            {
                if (!char.IsUpper(c))
                {
                    result += c;
                }
            }

            Console.WriteLine("Результат:\n" + result);
        }
    }
}
