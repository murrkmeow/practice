namespace task3
{
    public class Athlete : IPrototype<Athlete>
    {
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Sport { get; set; }

        public Athlete(string name, int? age, string sport)
        {
            Name = name;
            Age = age;
            Sport = sport;
        }

        public Athlete Clone()
        {
            return new Athlete(this.Name, this.Age, this.Sport);
        }

        public override string ToString()
        {
            return $"Имя: {Name}, Возраст: {(Age.HasValue ? Age.ToString() : "не указан")}, Вид спорта: {Sport}";
        }
    }
}
