namespace task1
{
    using System;

    class WritingTable : Table
    {
        private string material;
        private double decorationCost;

        public WritingTable(string name, double area, string material, double decorationCost)
            : base(name, area)
        {
            this.material = material;
            this.decorationCost = decorationCost;
        }

        public double GetDecorationCost()
        {
            return base.GetCost(0) * 0.1; 
        }

        public double GetTotalCost(double k)
        {
            return GetCost(k) + decorationCost + GetDecorationCost();
        }

        public override double GetCost(double k)
        {
            return base.GetCost(k);
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Материал: {material}, Стоимость отделки: {decorationCost}");
        }
    }

}
