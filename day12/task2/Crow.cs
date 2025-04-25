namespace task2
{
    using System;

    class Crow : Bird
    {
        private int count; 

        public Crow(string name, int count) : base(name)
        {
            this.count = count;
        }

        public override double GetFoodAmount()
        {
            return count * 0.15; 
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Вороны: {Name}, Кол-во: {count}");
            Console.WriteLine($"Пища в день: {GetFoodAmount():F2} кг\n");
        }
    }

}
