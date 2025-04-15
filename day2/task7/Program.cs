namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Таблицы перевода дюймов в сантиметры:");

            double d = 25.4f;

            for (int i = 2; i <= 24; i += 2)
            {
                Console.WriteLine($"{i} д. = {d * i} сант.");
            }

            Console.WriteLine("_____________________________\n");

            int j = 2;

            while (j <= 24)
            {
                Console.WriteLine($"{j} д. = {d * j} сант.");
                j += 2;
            }

            Console.WriteLine("_____________________________\n");
            
            int t = 2;

            do
            {
                Console.WriteLine($"{t} д. = {d * t} сант.");
                t += 2;
            } while (t <= 24);
        }
    }
}
