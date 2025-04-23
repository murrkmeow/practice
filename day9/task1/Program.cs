namespace task1
{
    internal class Program
    {
        struct WORKER
        {
            public string FullName; 
            public string Position;
            public int YearOfEmployment; 
        }

        static void Main()
        {
            const int numberOfWorkers = 3;
            WORKER[] workers = new WORKER[numberOfWorkers];

            Console.WriteLine("Введите данные о 3 работниках:");
            for (int i = 0; i < numberOfWorkers; i++)
            {
                Console.WriteLine($"Работник {i + 1}:");
                Console.Write("Фамилия и инициалы: ");
                workers[i].FullName = Console.ReadLine()!;
                Console.Write("Должность: ");
                workers[i].Position = Console.ReadLine()!;
                Console.Write("Год поступления на работу: ");
                workers[i].YearOfEmployment = int.Parse(Console.ReadLine()!);
            }

            workers = workers.OrderBy(w => w.FullName).ToArray();

            Console.WriteLine("\nУпорядоченный список работников:");
            foreach (var worker in workers)
            {
                Console.WriteLine($"{worker.FullName}, {worker.Position}, {worker.YearOfEmployment}");
            }

            Console.Write("\nВведите минимальный стаж работы: ");
            int minimumExperience = int.Parse(Console.ReadLine()!);
            int currentYear = DateTime.Now.Year;

            var experiencedWorkers = workers
                .Where(w => currentYear - w.YearOfEmployment > minimumExperience)
                .ToArray();

            if (experiencedWorkers.Length > 0)
            {
                Console.WriteLine("\nРаботники с требуемым стажем:");
                foreach (var worker in experiencedWorkers)
                {
                    Console.WriteLine(worker.FullName);
                }
            }
            else
            {
                Console.WriteLine("\nНет работников с указанным стажем.");
            }
        }
    }
}
