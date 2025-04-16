namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("      Книга");
            Book book = new Book();
            Console.WriteLine(book.DisplayInfo());

            Console.WriteLine("      Журнал");
            Journal journal = new Journal();
            Console.WriteLine(journal.DisplayInfo());

            Console.WriteLine("      Учебник");
            Textbook textbook = new Textbook();
            Console.WriteLine(textbook.DisplayInfo());

            Console.WriteLine("      Печатное издание");
            Magazine magazine = new Magazine();
            Console.WriteLine(magazine.DisplayInfo());
        }
    }
}