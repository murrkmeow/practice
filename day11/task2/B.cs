namespace task2
{
    class B : A
    {
        private int d;

        public int C2
        {
            get
            {
                if (d > 10)
                    return AValue + BValue + d;
                else
                    return AValue + BValue - d;
            }
        }

        public B() : base()
        {
            d = 7;
            Console.WriteLine("Вызван конструктор класса B (наследуемый от A)");
        }

        public B(int dValue)
        {
            d = dValue;
            Console.WriteLine("Вызван собственный конструктор класса B с параметром");
        }

        public void PrintC2()
        {
            Console.WriteLine($"Свойство C2: {C2}");
        }
    }

}
