namespace task2
{
    internal class Program
    {
        static void Main()
        {
            Bird[] birds = new Bird[]
            {
            new Stork("Белый аист", 5.2),
            new Crow("Городская стая", 8),
            new Stork("Африканский аист", 6.1),
            new Crow("Лесная стая", 5),
            new Stork("Аист с клювом", 4.8)
            };

            double totalStorkFood = 0;
            double totalCrowFood = 0;

            Console.WriteLine("Потребность птиц в пище\n");

            foreach (Bird bird in birds)
            {
                bird.PrintInfo();

                if (bird is Stork)
                    totalStorkFood += bird.GetFoodAmount();
                else if (bird is Crow)
                    totalCrowFood += bird.GetFoodAmount();
            }

            Console.WriteLine("Итоги");
            Console.WriteLine($"Общая пища для аистов: {totalStorkFood:F2} кг");
            Console.WriteLine($"Общая пища для ворон: {totalCrowFood:F2} кг");
        }
    }

}
