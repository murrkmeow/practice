namespace task4
{
    internal class Program
    {
        static void Main()
        {
            Notifier notifier = new Notifier();

            Observer1 observer1 = new Observer1();
            Observer2 observer2 = new Observer2();

            notifier.OnNotify += observer1.HandlerA;
            notifier.OnNotify += observer1.HandlerB;

            notifier.OnNotify += observer2.HandlerC;

            notifier.TriggerEvent("Первое сообщение");

            Console.WriteLine("\nУдаляем обработчик HandlerB...");
            notifier.OnNotify -= observer1.HandlerB;

            notifier.TriggerEvent("Второе сообщение");
        }
    }
}
