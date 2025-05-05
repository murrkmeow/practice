class Program
{
    static void Main()
    {
        string folderPath = "New_folder";

        try
        {
            // Создание папки
            Directory.CreateDirectory(folderPath);
            Console.WriteLine($"Папка \"{folderPath}\" успешно создана!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
