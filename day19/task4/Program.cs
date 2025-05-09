namespace task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Добавить диск");
                Console.WriteLine("2. Удалить диск");
                Console.WriteLine("3. Просмотр всех дисков");
                Console.WriteLine("4. Добавить песню на диск");
                Console.WriteLine("5. Удалить песню с диска");
                Console.WriteLine("6. Просмотр песен на диске");
                Console.WriteLine("7. Выйти из программы");
                Console.Write("Выберите действие (1-7): ");

                string choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите имя диска для добавления: ");
                        string diskNameToAdd = Console.ReadLine()!;
                        catalog.AddDisk(diskNameToAdd);
                        break;

                    case "2":
                        Console.Write("Введите имя диска для удаления: ");
                        string diskNameToRemove = Console.ReadLine()!;
                        catalog.RemoveDisk(diskNameToRemove);
                        break;

                    case "3":
                        catalog.DisplayAllDisks();
                        break;

                    case "4":
                        Console.Write("Введите имя диска для добавления песни: ");
                        string diskNameForSongAdd = Console.ReadLine()!;
                        Disk diskToAddSong = catalog.GetDisk(diskNameForSongAdd);
                        if (diskToAddSong != null)
                        {
                            Console.Write("Введите название песни для добавления: ");
                            string songToAdd = Console.ReadLine()!;
                            diskToAddSong.AddSong(songToAdd);
                        }
                        break;

                    case "5":
                        Console.Write("Введите имя диска для удаления песни: ");
                        string diskNameForSongRemove = Console.ReadLine()!;
                        Disk diskToRemoveSong = catalog.GetDisk(diskNameForSongRemove);
                        if (diskToRemoveSong != null)
                        {
                            Console.Write("Введите название песни для удаления: ");
                            string songToRemove = Console.ReadLine()!;
                            diskToRemoveSong.RemoveSong(songToRemove);
                        }
                        break;

                    case "6":
                        Console.Write("Введите имя диска для просмотра песен: ");
                        string diskNameForDisplay = Console.ReadLine()!;
                        Disk diskToDisplay = catalog.GetDisk(diskNameForDisplay);
                        if (diskToDisplay != null)
                        {
                            diskToDisplay.DisplaySongs();
                        }
                        break;

                    case "7":
                        Console.WriteLine("Выход из программы...");
                        return;

                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, выберите номер от 1 до 7.");
                        break;
                }
            }
        }
    }
}
