using System.Text.RegularExpressions;

namespace task2
{
    internal class Program
    {
        static void Main()
        {

            string pattern = @"^[\p{IsBasicLatin}\p{P}\s]+$";

            bool isEnglish = Regex.IsMatch(Console.ReadLine()!, pattern);

            Console.WriteLine($"Текст на английском: {isEnglish}");
        }
    }

}
