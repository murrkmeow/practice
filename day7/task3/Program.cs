namespace task3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите предложение:");
            string input = Console.ReadLine()!;

            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length < 3)
            {
                Console.WriteLine("В предложении должно быть как минимум три слова.");
                return;
            }

            Console.WriteLine("\nОригинальное предложение:");
            Console.WriteLine(string.Join(" ", words));
            
            //1
            string[] swappedWords = (string[])words.Clone();
            string temp = swappedWords[0];
            swappedWords[0] = swappedWords[swappedWords.Length - 1];
            swappedWords[swappedWords.Length - 1] = temp;
            Console.WriteLine("\n1. Первое и последнее слова поменяны местами:\n" + string.Join(" ", swappedWords));

            //2
            string glued = words[1] + words[2];
            Console.WriteLine("\n2. Второе и третье слова склеены:\n" + glued);
            
            //3
            char[] reversed = words[2].ToCharArray();
            Array.Reverse(reversed);
            Console.WriteLine("\n3. Третье слово в обратном порядке:\n" + new string(reversed));

            //4
            string cutFirstWord = words[0].Length > 2 ? words[0].Substring(2) : "";
            Console.WriteLine("\n4. Первое слово без первых двух букв:\n" + cutFirstWord);
        }
    }
}
