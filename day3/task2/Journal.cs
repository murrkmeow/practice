namespace task2
{
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
}