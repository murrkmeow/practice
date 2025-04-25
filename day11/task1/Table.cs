namespace task1
{
    class Table
    {
        private string name;
        private double area;

        public Table(string name, double area)
        {
            this.name = name;
            this.area = area;
        }

        public string GetName()
        {
            return name;
        }

        public double GetArea()
        {
            return area;
        }

        public virtual double GetCost(double k)
        {
            return Math.Pow(area, 2) / 3 + k;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Стол: {name}, Площадь: {area} см^2");
        }
    }

}
