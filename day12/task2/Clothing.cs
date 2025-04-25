namespace task2
{
    abstract class Clothing
    {
        private string name;

        public Clothing(string name)
        {
            this.name = name;
        }

        public string Name => name;

        public abstract void PrintInfo();
    }
}
