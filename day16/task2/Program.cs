namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dict = new MyDictionary<string, int>();
            dict.Add("apple", 3);
            dict.Add("banana", 5);
            dict.Add("cherry", 2);

            Console.WriteLine("Количество элементов: " + dict.Count);
            Console.WriteLine("Значение по ключу 'banana': " + dict["banana"]);
        }
    }
}
