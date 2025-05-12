using task1;

public class HasQuarterState : IState
{
    private readonly GumballMachine _machine;

    public HasQuarterState(GumballMachine machine)
    {
        _machine = machine;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("Нельзя вставить вторую монету");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Монета возвращена");
        _machine.State = _machine.NoQuarterState;
    }

    public void TurnCrank()
    {
        Console.WriteLine("Вы повернули рычаг...");
        _machine.State = _machine.SoldState;
    }

    public void Dispense()
    {
        Console.WriteLine("Жвачка не выдана");
    }
}
