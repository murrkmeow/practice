namespace task4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите фамилию, имя и отчество:");
            string input = Console.ReadLine()!;

            input = input.ToUpper();

            int sum = 0;
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    int position = GetRussianAlphabetPosition(c);
                    if (position > 0)
                    {
                        sum += position;
                    }
                }
            }

            Console.WriteLine($"Сумма значений букв: {sum}");

            int personalityCode = ReduceToSingleDigit(sum);
            Console.WriteLine($"Код личности: {personalityCode}");
        }

        static int GetRussianAlphabetPosition(char c)
        {
            string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            int index = alphabet.IndexOf(c);
            return index >= 0 ? index + 1 : 0;
        }

        static int ReduceToSingleDigit(int number)
        {
            while (number >= 10)
            {
                number = number.ToString().ToCharArray().Sum(ch => ch - '0');
            }
            return number;
        }
    }
}
