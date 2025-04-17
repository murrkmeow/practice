namespace task3
{
    internal class TwoDimensionalArray
    {
        private int[,] array;

        public TwoDimensionalArray(int rows, int cols)
        {
            array = new int[rows, cols];
        }

        public int this[int i, int j]
        {
            get => array[i, j];
            set => array[i, j] = value;
        }

        public int MainDiagonalSum()
        {
            int sum = 0;
            int size = Math.Min(array.GetLength(0), array.GetLength(1)); // Учитываем размер массива
            for (int i = 0; i < size; i++)
            {
                sum += array[i, i];
            }
            return sum;
        }

        public static bool operator >(TwoDimensionalArray a, TwoDimensionalArray b)
        {
            return a.MainDiagonalSum() > b.MainDiagonalSum();
        }

        public static bool operator <(TwoDimensionalArray a, TwoDimensionalArray b)
        {
            return a.MainDiagonalSum() < b.MainDiagonalSum();
        }
    }

    class Program
    {
        static void Main()
        {
            TwoDimensionalArray array1 = new TwoDimensionalArray(3, 3);
            TwoDimensionalArray array2 = new TwoDimensionalArray(3, 3);

            Console.WriteLine("Введите элементы первого массива:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    array1[i, j] = int.Parse(Console.ReadLine()!);
                }
            }

            Console.WriteLine("Введите элементы второго массива:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    array2[i, j] = int.Parse(Console.ReadLine()!);
                }
            }

            Console.WriteLine("\nРезультат сравнения:");
            Console.WriteLine(array1 > array2 ? "Первый массив больше второго." : "Первый массив меньше или равен второму.");
        }
    }

}
