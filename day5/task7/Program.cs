namespace task7
{
    internal class Program
    {
        static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Console.WriteLine("Введите два числа:");
                    int a = int.Parse(Console.ReadLine()!);
                    int b = int.Parse(Console.ReadLine()!);

                    Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Нужно ввести число!");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Ошибка: Делить на нуль нельзя!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Какая-то ошибка: {0}", ex.Message);
                }
                finally
                {
                    Console.WriteLine("После try-блока.");
                }
            }
        }
    }
     //при а = 4, b = 2 программа работает исправно 
     //при a = 3 b = g выводится ошибка "нужно ввести число " т.к. ловится Format Exception
     //при а = d b = 1 ошибка Format exception ловится уже на моменте инициализации а 
     //при a = 1 b = 0 ловится Divide By Zero Exception и выводится сообщение "делить на нуль нельзя"
     //при a=123456789987654321, b=1 выводится исключение не предусмотренное нашей программой и пишет что число слишком большое
}
