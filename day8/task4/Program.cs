using System.Text.RegularExpressions;

namespace task4
{
    internal class Program
    {
        static void Main()
        {
            string text = "Текст содержит слова: стол, block, кран, frost, мир, идея, test, бум, тракт.";

            string pattern = @"\b\w*[бвгджзйклмнпрстфхцчшщbcdfghjklmnpqrstvwxyz]{2}\b";

            MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);

            Console.WriteLine("Слова, оканчивающиеся на две согласные:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
