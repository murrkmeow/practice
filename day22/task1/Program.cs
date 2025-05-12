public class Program
{
    public static void Main()
    {
        var machine = new GumballMachine(5);

        Console.WriteLine("Попытка 1:");
        machine.InsertQuarter();
        machine.TurnCrank();

        Console.WriteLine("\nПопытка 2:");
        machine.InsertQuarter();
        machine.EjectQuarter();
        machine.TurnCrank();

        Console.WriteLine("\nПопытка 3:");
        machine.InsertQuarter();
        machine.TurnCrank();
        machine.InsertQuarter();
        machine.TurnCrank();
        machine.EjectQuarter();
    }
}