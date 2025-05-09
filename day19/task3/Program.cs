namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AthleteManager manager = new AthleteManager();

            manager.AddAthlete(new Athlete("Иван", 25, "Бокс"));
            manager.AddAthlete(new Athlete("Мария", null, "Плавание"));
            manager.AddAthlete(new Athlete("Анна", 19, "Теннис"));

            Console.WriteLine("Исходный список:");
            manager.PrintAll();

            List<Athlete> копии = manager.CloneAll(manager.Athletes);
            Console.WriteLine("\nКопии:");
            foreach (var a in копии)
                Console.WriteLine(a);

            manager.RemoveAthlete("Мария");

            Console.WriteLine("\nПосле удаления Марии:");
            manager.PrintAll();

            Dictionary<string, Athlete> athleteDict = new Dictionary<string, Athlete>();
            foreach (var a in manager.Athletes)
            {
                athleteDict[a.Name] = a;
            }

            Console.WriteLine("\nДоступ по имени через Dictionary:");
            if (athleteDict.TryGetValue("Иван", out Athlete athlete))
            {
                Console.WriteLine(athlete);
            }
        }
    }
}
