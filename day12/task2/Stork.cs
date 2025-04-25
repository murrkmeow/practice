namespace task2
{
    using System;

    class Stork : Bird
    {
        private double weight; 

        public Stork(string name, double weight) : base(name)
        {
            this.weight = weight;
        }

        public override double GetFoodAmount()
        {
            return weight * 0.2;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Аист: {Name}, Вес: {weight} кг");
            Console.WriteLine($"Пища в день: {GetFoodAmount():F2} кг\n");
        }
    }

}
