using System.Globalization;

namespace task1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("a= ");
            double a = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

            Console.Write("b= ");
            double b = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

            Console.Write("c= ");
            double c = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

            Console.WriteLine("({0:0.00}+{1:0.00})+{2:0.00} = {0:0.00}+({1:0.00}+{2:0.00})",
                a, b, c);

            Console.ReadKey(); // пауза, как "нажмите любую клавишу"
        }
    }
}
