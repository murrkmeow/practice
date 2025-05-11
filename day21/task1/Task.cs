namespace task1
{
    class Task
    {
        public int Number { get; set; }

        public Task(int number)
        {
            if (number < 100 || number > 999)
                throw new ArgumentException("Число должно быть трехзначным.");
            Number = number;
        }

        public int SwapFirstAndSecondDigits()
        {
            int first = Number / 100;
            int second = (Number / 10) % 10;
            int third = Number % 10;

            return second * 100 + first * 10 + third;
        }
    }
}
