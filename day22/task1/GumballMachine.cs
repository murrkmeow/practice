using task1;

public class GumballMachine
{
    public IState SoldOutState { get; }
    public IState NoQuarterState { get; }
    public IState HasQuarterState { get; }
    public IState SoldState { get; }

    public IState State { get; set; }
    public int Count { get; private set; }

    public GumballMachine(int numberGumballs)
    {
        SoldOutState = new SoldOutState(this);
        NoQuarterState = new NoQuarterState(this);
        HasQuarterState = new HasQuarterState(this);
        SoldState = new SoldState(this);

        Count = numberGumballs;
        State = numberGumballs > 0 ? NoQuarterState : SoldOutState;
    }

    public void InsertQuarter()
    {
        State.InsertQuarter();
    }

    public void EjectQuarter()
    {
        State.EjectQuarter();
    }

    public void TurnCrank()
    {
        State.TurnCrank();
        State.Dispense();
    }

    public void ReleaseBall()
    {
        Console.WriteLine("Жвачка выкатывается из слота...");
        if (Count != 0)
        {
            Count--;
        }
    }
}