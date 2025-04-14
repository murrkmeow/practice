namespace task6
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите трехзначное число: ");
            int number = int.Parse(Console.ReadLine()!);

            if (number < 100 || number > 999)
            {
                Console.WriteLine("Ошибка: число должно быть трехзначным.");
            }
            else
            {
                int digit1 = number % 10;           
                int digit2 = (number / 10) % 10;    
                int digit3 = number / 100;          

                int reversed = digit1 * 100 + digit2 * 10 + digit3;

                Console.WriteLine("Число, прочитанное справа налево: " + reversed);
            }
        }
    }
}
