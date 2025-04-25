namespace task2
{
    class Program
    {
        static void Main()
        {
            Clothing[] clothes = new Clothing[]
            {
            new Coat("Пальто зимнее", 52),
            new Suit("Костюм офисный", 1.75),
            new Coat("Пальто осеннее", 48),
            new Suit("Костюм спортивный", 1.85),
            new Coat("Пальто лёгкое", 50)
            };

            Console.WriteLine("Протокол расчёта расхода ткани:\n");

            foreach (Clothing item in clothes)
            {
                item.PrintInfo();
            }
        }
    }
}
