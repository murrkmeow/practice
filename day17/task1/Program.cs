class Program
{
    static void Main()
    {
        string filePath = "g.txt";

        try
        {
            // Читаем содержимое файла и разбиваем на числа
            var numbers = File.ReadAllText(filePath)
                              .Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                              .Select(int.Parse)
                              .ToArray();

            // Подсчитываем количество четных чисел
            int evenCount = numbers.Count(n => n % 2 == 0);

            Console.WriteLine($"Количество четных чисел: {evenCount}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
