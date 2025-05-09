namespace task3
{
    public class AthleteManager
    {
        public List<Athlete> Athletes { get; set; } = new List<Athlete>();

        public void AddAthlete(Athlete athlete)
        {
            Athletes.Add(athlete);
        }

        public void RemoveAthlete(string name)
        {
            Athletes.RemoveAll(a => a.Name == name);
        }

        public List<T> CloneAll<T>(List<T> items) where T : IPrototype<T>
        {
            List<T> clones = new List<T>();
            foreach (T item in items)
            {
                clones.Add(item.Clone());
            }
            return clones;
        }

        public void PrintAll()
        {
            foreach (var a in Athletes)
            {
                Console.WriteLine(a);
            }
        }
    }
}
