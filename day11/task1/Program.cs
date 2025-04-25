namespace task1
{
    internal class Program
    {
        static void Main()
        {
            Table table = new Table("Обеденный стол", 1200.0);
            table.Print();
            Console.WriteLine($"Стоимость (k = 150): {table.GetCost(150)}\n");

            WritingTable writingTable = new WritingTable("Письменный стол", 800.0, "Дуб", 300.0);
            writingTable.Print();
            Console.WriteLine($"Базовая стоимость (k = 150): {writingTable.GetCost(150)}");
            Console.WriteLine($"Стоимость отделки (10%): {writingTable.GetDecorationCost()}");
            Console.WriteLine($"Полная стоимость: {writingTable.GetTotalCost(150)}");
        }
    }
}
