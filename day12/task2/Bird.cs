namespace task2
{
    abstract class Bird
    {
        private string name;

        public Bird(string name)
        {
            this.name = name;
        }

        public string Name => name;

        public abstract void PrintInfo();
        public abstract double GetFoodAmount();
    }

}
