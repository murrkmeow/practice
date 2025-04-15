namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Узнать популярные программы для телеканалов:\n" +
                                "1. Первый канал.\n" +
                                "2. МузТВ\n" +
                                "3. НТВ\n");
            Console.WriteLine("Введите номер канала: ");

            int num = int.Parse(Console.ReadLine()!);

            switch (num)
            {
                case 1: Console.WriteLine("- Новости\n- Спорт\n- Кулинарное шоу"); break;
                case 2: Console.WriteLine("- Документальные фильмы\n- Музыкальные концерты\n- Ток-шоу"); break;
                case 3: Console.WriteLine("- Сериалы\n- Комедийные шоу\n- Детские передачи"); break;
                default: Console.WriteLine("Нет информации про этот канал."); break;
            }
        }
    }
}
