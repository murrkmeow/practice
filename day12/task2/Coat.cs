namespace task2
{
    class Coat : Clothing
    {
        private double sizeV;

        public Coat(string name, double sizeV) : base(name)
        {
            this.sizeV = sizeV;
        }

        public double FabricConsumption()
        {
            return sizeV / 6.5 + 0.5;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Тип: Пальто\nНазвание: {Name}, Размер V: {sizeV}");
            Console.WriteLine($"Расход ткани: {FabricConsumption():F2} м²\n");
        }
    }
}
