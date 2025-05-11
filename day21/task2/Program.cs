using System;
using System.Threading;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main()
        {
            double b = 3.0;
    
            MathTask[] taskObjects = new MathTask[]
            {
                new MathTask(b, 1, 2000),
                new MathTask(b, 2, 500)  
            };
    
            Task[] tasks = new Task[2];
            for (int i = 0; i < 2; i++)
            {
                int index = i; 
                tasks[i] = Task.Run(() => taskObjects[index].Compute());
            }
    
            Task.WhenAny(tasks).ContinueWith(_ =>
            {
                Console.WriteLine("Хотя бы одна задача завершена.");
            }).Wait();
    
            Task.WaitAll(tasks);
            Console.WriteLine("Все задачи завершены:");
            Console.WriteLine($"Результат z1 = {taskObjects[0].Result:F4}");
            Console.WriteLine($"Результат z2 = {taskObjects[1].Result:F4}");
        }
    }
}
