class Program
{
    static void Main()
    {
        string filePath = "textfile.txt";
        string[] lines =
        {
            "Первая строка",
            "Вторая строка, она длиннее",
            "Короткая",
            "Очень длинная строка, которая значительно превосходит другие",
            "Средняя длина строки"
        };

        File.WriteAllLines(filePath, lines);
        Console.WriteLine($"Файл \"{filePath}\" успешно создан!");
        var fileLines = File.ReadAllLines(filePath);
        int maxLength = fileLines.Max(line => line.Length);
        Console.WriteLine($"Длина самой длинной строки: {maxLength}");
    }
}
