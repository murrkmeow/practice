namespace task1
{
    internal class Program
    {
        static void Main()
        {
            // обычное создание через конструктор
            Task task1 = new Task(123);
            Console.WriteLine("Результат 1: " + task1.SwapFirstAndSecondDigits());

            // создание через переменную и присвоение позже
            Task task2;
            task2 = new Task(456);
            Console.WriteLine("Результат 2: " + task2.SwapFirstAndSecondDigits());

            // создание объекта через var (неявная типизация)
            var task3 = new Task(789);
            Console.WriteLine("Результат 3: " + task3.SwapFirstAndSecondDigits());
        }
    }
}
