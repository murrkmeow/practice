using System.Collections;

namespace task4
{
    public class Disk
    {
        public string Name { get; set; }
        public ArrayList Songs { get; set; }

        public Disk(string name)
        {
            Name = name;
            Songs = new ArrayList();
        }

        public void AddSong(string song)
        {
            Songs.Add(song);
            Console.WriteLine($"Песня '{song}' добавлена на диск '{Name}'.");
        }

        public void RemoveSong(string song)
        {
            if (Songs.Contains(song))
            {
                Songs.Remove(song);
                Console.WriteLine($"Песня '{song}' удалена с диска '{Name}'.");
            }
            else
            {
                Console.WriteLine($"Песня '{song}' не найдена на диске '{Name}'.");
            }
        }

        public void DisplaySongs()
        {
            Console.WriteLine($"Содержимое диска '{Name}':");
            if (Songs.Count == 0)
            {
                Console.WriteLine("На диске нет песен.");
            }
            else
            {
                foreach (string song in Songs)
                {
                    Console.WriteLine($"- {song}");
                }
            }
        }
    }
}
