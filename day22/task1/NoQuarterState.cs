using task1;

public class NoQuarterState : IState
{
    private readonly GumballMachine _machine;

    public NoQuarterState(GumballMachine machine)
    {
        _machine = machine;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("Вы вставили монету");
        _machine.State = _machine.HasQuarterState;
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Вы не вставляли монету");
    }

    public void TurnCrank()
    {
        Console.WriteLine("Вы дернули рычаг, но сначала нужно вставить монету");
    }

    public void Dispense()
    {
        Console.WriteLine("Сначала нужно оплатить");
    }
}