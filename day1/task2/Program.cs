namespace task2
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите трехзначное число: ");
            int number = int.Parse(Console.ReadLine()!);

            if (number < 100 || number > 999)
            {
                Console.WriteLine("Число должно быть трехзначным!");
            }
            else
            {
                int first = number / 100;          
                int second = (number / 10) % 10;   
                int third = number % 10;           

                int newNumber = second * 100 + first * 10 + third;

                Console.WriteLine("Число после перестановки первой и второй цифр: " + newNumber);
            }
        }
    }
}
