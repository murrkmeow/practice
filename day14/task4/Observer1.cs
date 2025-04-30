namespace task4
{
    class Observer1
    {
        public void HandlerA(string msg)
        {
            Console.WriteLine($"Observer1.HandlerA получил сообщение: {msg}");
        }

        public void HandlerB(string msg)
        {
            Console.WriteLine($"Observer1.HandlerB получил сообщение: {msg}");
        }
    }

}
