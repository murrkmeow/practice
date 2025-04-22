namespace task1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine()!;

            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(words);

            string result = string.Join(" ", words);

            Console.WriteLine("Результат:\n" + result);
        }
    }
}
