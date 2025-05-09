using System.Collections;

namespace task4
{
    public class Catalog
    {
        private Hashtable disks;

        public Catalog()
        {
            disks = new Hashtable();
        }

        public void AddDisk(string diskName)
        {
            if (!disks.ContainsKey(diskName))
            {
                disks[diskName] = new Disk(diskName);
                Console.WriteLine($"Диск '{diskName}' добавлен в каталог.");
            }
            else
            {
                Console.WriteLine($"Диск '{diskName}' уже существует в каталоге.");
            }
        }

        public void RemoveDisk(string diskName)
        {
            if (disks.ContainsKey(diskName))
            {
                disks.Remove(diskName);
                Console.WriteLine($"Диск '{diskName}' удален из каталога.");
            }
            else
            {
                Console.WriteLine($"Диск '{diskName}' не найден в каталоге.");
            }
        }

        public void DisplayAllDisks()
        {
            Console.WriteLine("Содержимое каталога:");
            if (disks.Count == 0)
            {
                Console.WriteLine("Каталог пуст.");
            }
            else
            {
                foreach (DictionaryEntry entry in disks)
                {
                    Console.WriteLine($"- {entry.Key}");
                }
            }
        }

        public Disk GetDisk(string diskName)
        {
            if (disks.ContainsKey(diskName))
            {
                return (Disk)disks[diskName];
            }
            else
            {
                Console.WriteLine($"Диск '{diskName}' не найден в каталоге.");
                return null;
            }
        }
    }
}
