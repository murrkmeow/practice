namespace task3
{
    internal class Program
    {
        static void Main()
        {
            MyInfo info = new MyInfo();

            info.NameChanged += (sender, newName) =>
            {
                Console.WriteLine($"Имя изменено на: {newName}");
            };

            info.Name = "Алексей";

            info.Name = "Алексей";

            info.Name = "Мария";
        }
    }

}
