using System.Text.RegularExpressions;

namespace task3
{
    internal class Program
    {
        static void Main()
        {
            string text = "Контакты: john.doe@example.com, support@site.co.uk, а также test_email123@my-mail.ru.";

            string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";

            MatchCollection matches = Regex.Matches(text, pattern);

            Console.WriteLine("Найденные e-mail адреса:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
