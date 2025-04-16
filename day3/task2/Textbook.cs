namespace task2
{
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
}