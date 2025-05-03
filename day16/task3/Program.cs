namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            int[] array = myList.GetArray();

            Console.WriteLine("Элементы массива:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
