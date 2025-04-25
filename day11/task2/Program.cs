namespace task2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Создание объекта класса A:");
            A objA = new A();
            objA.PrintC();

            Console.WriteLine("\nСоздание объекта класса B (через базовый конструктор):");
            B objB1 = new B();
            objB1.PrintC2();

            Console.WriteLine("\nСоздание объекта класса B (через собственный конструктор):");
            B objB2 = new B(15);
            objB2.PrintC2();
        }
    }

}
