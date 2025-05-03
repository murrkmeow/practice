namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);

            Console.WriteLine("Количество элементов: " + list.Count);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"Элемент {i}: {list[i]}");
            }
        }
    }
}
