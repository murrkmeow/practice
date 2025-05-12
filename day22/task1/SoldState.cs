using task1;

public class SoldState : IState
{
    private readonly GumballMachine _machine;

    public SoldState(GumballMachine machine)
    {
        _machine = machine;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("Подождите, мы уже выдаем вам жвачку");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Извините, вы уже дернули рычаг");
    }

    public void TurnCrank()
    {
        Console.WriteLine("Двойное нажатие не даст вам вторую жвачку!");
    }

    public void Dispense()
    {
        _machine.ReleaseBall();
        if (_machine.Count > 0)
        {
            _machine.State = _machine.NoQuarterState;
        }
        else
        {
            Console.WriteLine("Упс, жвачки закончились!");
            _machine.State = _machine.SoldOutState;
        }
    }
}