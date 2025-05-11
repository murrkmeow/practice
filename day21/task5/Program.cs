using System;
using System.Numerics;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main()
        {
            int[] values = { 3, 70, 54 };
            int sumThreshold = 500;
            BigInteger productThreshold = 500;

            bool isStopped = false;
            object lockObj = new object();

            Parallel.ForEach(values, (n, state) =>
            {
                if (Volatile.Read(ref isStopped))
                {
                    state.Stop();
                    return;
                }

                int sum = 0;
                for (int i = 0; i <= n; i++)
                    sum += i;

                BigInteger product = 1;
                for (int i = 1; i <= n; i++)
                    product *= i;

                Console.WriteLine($"N = {n}, Сумма = {sum}, Произведение = {product}");

                if (sum > sumThreshold || product > productThreshold)
                {
                    lock (lockObj)
                    {
                        if (!isStopped)
                        {
                            Console.WriteLine($"--> Прерывание по условию при N = {n}");
                            isStopped = true;
                            state.Stop();
                        }
                    }
                }
            });

            Console.WriteLine("Выполнение завершено.");
        }
    }
}
