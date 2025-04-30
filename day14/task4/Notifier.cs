namespace task4
{
    class Notifier
    {
        public delegate void NotifyEventHandler(string message);

        public event NotifyEventHandler OnNotify;

        public void TriggerEvent(string msg)
        {
            Console.WriteLine("\nСобытие инициировано:");
            OnNotify?.Invoke(msg);
        }
    }

}
