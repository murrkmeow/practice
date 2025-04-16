namespace task2
{
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
}