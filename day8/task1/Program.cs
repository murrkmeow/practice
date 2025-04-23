using System.Text.RegularExpressions;

namespace task1
{
    internal class Program
    {
        static void Main()
        {
            string text = "Это пример текста с такими словами, как полу-правда, слово, и даже два-дефиса-есть, а также без-дефисов.";

            string pattern = @"\b[а-яА-Яa-zA-Z-]+\b";

            MatchCollection matches = Regex.Matches(text, pattern);

            Console.WriteLine("Слова с не более чем одним дефисом:");
            foreach (Match match in matches)
            {
                string word = match.Value;
                int dashCount = word.Split('-').Length - 1;

                if (dashCount <= 1)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
