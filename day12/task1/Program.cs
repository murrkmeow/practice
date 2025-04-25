namespace task1
{
    class Program
    {
        static void Main()
        {
            Clothing[] clothes = new Clothing[5];

            clothes[0] = new Coat("Пальто зимнее", 52);
            clothes[1] = new Suit("Костюм офисный", 1.75);
            clothes[2] = new Coat("Пальто весеннее", 46);
            clothes[3] = new Suit("Костюм спортивный", 1.8);
            clothes[4] = new Coat("Пальто демисезонное", 50);

            Console.WriteLine("Протокол расчёта расхода ткани:\n");

            foreach (Clothing item in clothes)
            {
                item.PrintInfo();
            }
        }
    }
}
