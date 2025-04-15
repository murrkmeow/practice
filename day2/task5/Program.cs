namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырехзначное число: ");
            int num = int.Parse(Console.ReadLine()!);

            if (num >= 1000 && num < 10000)
            {
                int first = num / 1000;
                int second = num % 1000 / 100;

                if (first > second)
                {
                    Console.WriteLine($"Первая цифра больше. ({first} > {second})");
                }
                else if (first < second)
                {
                    Console.WriteLine($"Вторая цифра больше. ({first} < {second})");
                }
                else
                {
                    Console.WriteLine($"Цифры равны. ({first} = {second})");
                }
            }
            else
            {
                Console.WriteLine("Число не четырехзначное.");
            }
        }
    }
}
