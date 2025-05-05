using System;
using System.IO;

class Program
{
    static void Main()
    {
        string targetDrive = "C:\\";
        string newDirectory = Path.Combine(targetDrive, "Exmple_38tp");
        string sourceDirectory = "C:\\done";
        string[] filesToCopy = Directory.GetFiles(sourceDirectory).Take(3).ToArray();

        Directory.CreateDirectory(newDirectory);
        Console.WriteLine($"Каталог \"{newDirectory}\" создан.");

        foreach (var file in filesToCopy)
        {
            string fileName = Path.GetFileName(file);
            string destFile = Path.Combine(newDirectory, fileName);
            File.Copy(file, destFile, true);
            File.SetAttributes(destFile, FileAttributes.Hidden);
            Console.WriteLine($"Файл \"{fileName}\" скопирован и скрыт.");

            string shortcutPath = Path.Combine(newDirectory, fileName + ".lnk");
            using (StreamWriter writer = new StreamWriter(shortcutPath))
            {
                writer.WriteLine($"Ссылка на файл: {file}");
            }
            Console.WriteLine($"Создана ссылка \"{shortcutPath}\".");
        }

        Console.WriteLine("\nСписок всех файлов на локальном диске:");
        foreach (var drive in DriveInfo.GetDrives())
        {
            if (drive.IsReady)
            {
                Console.WriteLine($"Файлы на диске {drive.Name}:");
                foreach (var file in Directory.GetFiles(drive.Name, "*.*", SearchOption.AllDirectories))
                {
                    Console.WriteLine(file);
                }

            }
        }
    }
}
