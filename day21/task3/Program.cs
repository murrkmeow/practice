using System;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main()
        {
            int number = 321;

            Task<int> reverseTask = new Task<int>(() =>
            {
                int hundreds = number / 100;
                int tens = (number / 10) % 10;
                int units = number % 10;

                return units * 100 + tens * 10 + hundreds;
            });

            Task printTask = reverseTask.ContinueWith(t =>
            {
                Console.WriteLine($"Число {number} наоборот: {t.Result}");
            });

            reverseTask.Start();

            printTask.Wait();
        }
    }
}
