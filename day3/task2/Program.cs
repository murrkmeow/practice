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

    public class Publication
    {
        protected string Title;
        protected string Publisher;
        protected int Year;

        public Publication()
        {
            Title = string.Empty;
            Publisher = string.Empty;
            Year = 0;
            InputDetails();
        }

        public void InputDetails()
        {
            Console.WriteLine("Введите название издания:");
            Title = Console.ReadLine();
            Console.WriteLine("Введите издателя:");
            Publisher = Console.ReadLine();
            Console.WriteLine("Введите год издания:");
            Year = int.Parse(Console.ReadLine()!);
        }

        public virtual string DisplayInfo()
        {
            return $"Название: {Title}, Издатель: {Publisher}, Год издания: {Year}.";
        }
    }

    public class Book : Publication
    {
        private string Author;

        public Book() : base()
        {
            Author = string.Empty;
            InputBookDetails();
        }

        private void InputBookDetails()
        {
            Console.WriteLine("Введите автора книги:");
            Author = Console.ReadLine();
        }

        public override string DisplayInfo()
        {
            return base.DisplayInfo() + $" Автор: {Author}.";
        }
    }

    public class Journal : Publication
    {
        private int IssueNumber;

        public Journal() : base()
        {
            IssueNumber = 0;
            InputJournalDetails();
        }

        private void InputJournalDetails()
        {
            Console.WriteLine("Введите номер выпуска журнала:");
            IssueNumber = int.Parse(Console.ReadLine()!);
        }

        public override string DisplayInfo()
        {
            return base.DisplayInfo() + $" Номер выпуска: {IssueNumber}.";
        }
    }

    public class Textbook : Publication
    {
        private string Subject;

        public Textbook() : base()
        {
            Subject = string.Empty;
            InputTextbookDetails();
        }

        private void InputTextbookDetails()
        {
            Console.WriteLine("Введите предмет учебника:");
            Subject = Console.ReadLine();
        }

        public override string DisplayInfo()
        {
            return base.DisplayInfo() + $" Предмет: {Subject}.";
        }
    }

    public class Magazine : Publication
    {
        private string Topic;

        public Magazine() : base()
        {
            Topic = string.Empty;
            InputMagazineDetails();
        }

        private void InputMagazineDetails()
        {
            Console.WriteLine("Введите тему журнала:");
            Topic = Console.ReadLine();
        }

        public override string DisplayInfo()
        {
            return base.DisplayInfo() + $" Тема журнала: {Topic}.";
        }
    }
}