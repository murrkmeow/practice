namespace task5
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Цена одного килограмма яблок (руб.): ");
            double pricePerKg = double.Parse(Console.ReadLine()!.Replace('.', ','));

            Console.Write("Вес яблок (кг): ");
            double weight = double.Parse(Console.ReadLine()!.Replace('.', ','));

            double totalCost = pricePerKg * weight;

            Console.WriteLine("Стоимость покупки: {0:0.00} руб.", totalCost);
        }
    }
}
