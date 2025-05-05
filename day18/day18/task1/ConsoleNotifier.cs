using Bank;

internal class ConsoleNotifier : INotifyer
{
    public void SendMessage(string message)
    {
        Console.WriteLine(message);
    }
}