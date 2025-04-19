namespace task4
{
    internal class Program
    {
        static void Main()
        {
            byte x = 200;
            byte y = 200;

            try
            {
                byte result = (byte)(x + y); // здесь больше нет unchecked
                Console.WriteLine("1: {0}", result);

                result = checked((byte)(x + y));
                Console.WriteLine("2: {0}", result);
            }
            catch (OverflowException)
            {
                Console.WriteLine("возникло переполнение");
            }
        }
    }
    //выводится все абсолютно также, возможно из-за того что операции над byte не проверяется переполнение в самой среде разработки
}
