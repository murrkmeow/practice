namespace task2
{
    class Suit : Clothing
    {
        private double heightH;

        public Suit(string name, double heightH) : base(name)
        {
            this.heightH = heightH;
        }

        public double FabricConsumption()
        {
            return 2 * heightH + 0.3;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Тип: Костюм\nНазвание: {Name}, Рост H: {heightH}");
            Console.WriteLine($"Расход ткани: {FabricConsumption():F2} м²\n");
        }
    }
}
