using task1;

public class SoldOutState : IState
{
    private readonly GumballMachine _machine;

    public SoldOutState(GumballMachine machine)
    {
        _machine = machine;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("Нельзя вставить монету, автомат пуст");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Нельзя вернуть монету, вы не вставляли её");
    }

    public void TurnCrank()
    {
        Console.WriteLine("Вы дернули рычаг, но жвачки закончились");
    }

    public void Dispense()
    {
        Console.WriteLine("Жвачка не выдана");
    }
}