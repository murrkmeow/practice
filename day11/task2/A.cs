namespace task2
{
    class A
    {
        private int a = 5;
        private int b = 3;

        public int C
        {
            get { return a + b; }
        }

        public A()
        {
            Console.WriteLine("Вызван конструктор класса A (по умолчанию)");
        }

        public void PrintC()
        {
            Console.WriteLine($"Свойство C (a + b): {C}");
        }

        protected int AValue => a;
        protected int BValue => b;
    }

}
