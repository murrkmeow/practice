namespace task2
{
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
}