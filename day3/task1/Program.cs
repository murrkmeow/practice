namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два целочисленных значения подряд: ");

            int first = int.Parse(Console.ReadLine()!);
            int second = int.Parse(Console.ReadLine()!);
            
            A a = new A(first, second);

            Console.WriteLine("Возведение в степень:" + a.Construction(first, second));
            Console.WriteLine("Результат уровнения:" + a.Calc(first, second));
        }
    }
}
