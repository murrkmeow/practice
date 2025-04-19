namespace task4
{
    internal class Program
    {
        static void Main()
        {
            const int wagons = 18;
            const int seatsPerWagon = 36;
            int[,] seats = new int[wagons, seatsPerWagon];

            Random rand = new Random();

            for (int i = 0; i < wagons; i++)
            {
                for (int j = 0; j < seatsPerWagon; j++)
                {
                    seats[i, j] = rand.NextDouble() < 0.95 ? 1 : 0;
                }
            }

            while (true)
            {
                Console.Write("\nВведите номер вагона (1-18) или 0 для выхода: ");
                if (!int.TryParse(Console.ReadLine(), out int wagonNumber) || wagonNumber < 0 || wagonNumber > wagons)
                {
                    Console.WriteLine("Некорректный ввод. Повторите попытку.");
                    continue;
                }

                if (wagonNumber == 0)
                    break;

                bool hasFreeSeats = false;

                for (int j = 0; j < seatsPerWagon; j++)
                {
                    if (seats[wagonNumber - 1, j] == 0)
                    {
                        hasFreeSeats = true;
                        break;
                    }
                }

                if (hasFreeSeats)
                {
                    Console.WriteLine($"В вагоне №{wagonNumber} есть свободные места.");
                }
                else
                {
                    Console.WriteLine($"В вагоне №{wagonNumber} все места заняты.");
                }
            }
        }
    }
}
