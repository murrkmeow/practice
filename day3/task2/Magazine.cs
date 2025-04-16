namespace task2
{
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