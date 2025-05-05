class Program
{
    static void Main()
    {
        string inputFile = "input.txt";
        string evenLinesFile = "even_lines.txt";
        string oddLinesFile = "odd_lines.txt";

        try
        {
            var lines = File.ReadAllLines(inputFile);

            var evenLines = lines.Where((line, index) => index % 2 == 1).ToArray();
            var oddLines = lines.Where((line, index) => index % 2 == 0).ToArray();

            File.WriteAllLines(evenLinesFile, evenLines);
            File.WriteAllLines(oddLinesFile, oddLines);

            Console.WriteLine($"Четные строки записаны в \"{evenLinesFile}\"");
            Console.WriteLine($"Нечетные строки записаны в \"{oddLinesFile}\"");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
