namespace add
{
    internal class Program
    {
        static void Main()
        {
            int size = 7;
            int[,] matrix = new int[size, size];

            int value = 1;
            int top = 0, bottom = size - 1;
            int left = 0, right = size - 1;

            while (value <= size * size)
            {
                for (int i = left; i <= right; i++)
                    matrix[top, i] = value++;
                top++;

                for (int i = top; i <= bottom; i++)
                    matrix[i, right] = value++;
                right--;

                for (int i = right; i >= left; i--)
                    matrix[bottom, i] = value++;
                bottom--;

                for (int i = bottom; i >= top; i--)
                    matrix[i, left] = value++;
                left++;
            }

            Console.WriteLine("Матрица 7x7, заполненная по спирали:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(3));
                }
                Console.WriteLine();
            }
        }
    }
}
