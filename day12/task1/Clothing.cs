namespace task1
{
    class Clothing
    {
        private string name;

        public Clothing(string name)
        {
            this.name = name;
        }

        public string Name => name;

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Одежда: {name}");
        }
    }

}
