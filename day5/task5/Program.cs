namespace task5
{
    internal class Program
    {
        static void Main()
        {
            byte n = 1;
            byte i;

            try
            {
                checked // блок без проверки переполнения
                {
                    for (i = 1; i < 10; i++) n *= i;
                    Console.WriteLine("1: {0}", n);
                }

                unchecked // блок с проверкой переполнения
                {
                    n = 1;
                    for (i = 1; i < 10; i++) n *= i;
                    Console.WriteLine("2: {0}", n);
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("возникло переполнение");
            }
        }
    }
    //в выводе только "возникло переполнение" т.к. в блоке checked уже было словлено переполнение
    //и компилятор идет сразу к блоку catch и даже не берет unchecked в оборот
}
