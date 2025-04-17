using System;

namespace task5
{
    class RealMatrix
    {
        private double[,] data;

        public int Rows { get; private set; }
        public int Columns { get; private set; }

        public RealMatrix()
        {
            Rows = 1;
            Columns = 1;
            data = new double[1, 1];
            data[0, 0] = 1.0;
        }

        public RealMatrix(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
                throw new ArgumentException("Размеры матрицы должны быть положительными.");

            Rows = rows;
            Columns = columns;
            data = new double[rows, columns];
        }

        public double this[int i, int j]
        {
            get => data[i, j];
            set => data[i, j] = value;
        }

        public RealMatrix Clone()
        {
            RealMatrix result = new RealMatrix(Rows, Columns);
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                    result[i, j] = data[i, j];
            return result;
        }

        public static RealMatrix operator *(RealMatrix matrix, double scalar)
        {
            RealMatrix result = matrix.Clone();
            for (int i = 0; i < matrix.Rows; i++)
                for (int j = 0; j < matrix.Columns; j++)
                    result[i, j] *= scalar;
            return result;
        }

        public static RealMatrix operator /(RealMatrix matrix, double scalar)
        {
            if (scalar == 0)
                throw new DivideByZeroException();
            RealMatrix result = matrix.Clone();
            for (int i = 0; i < matrix.Rows; i++)
                for (int j = 0; j < matrix.Columns; j++)
                    result[i, j] /= scalar;
            return result;
        }

        public static RealMatrix operator *(RealMatrix a, RealMatrix b)
        {
            if (a.Columns != b.Rows)
                throw new InvalidOperationException("Несовместимые размеры матриц для умножения.");

            RealMatrix result = new RealMatrix(a.Rows, b.Columns);

            for (int i = 0; i < a.Rows; i++)
                for (int j = 0; j < b.Columns; j++)
                    for (int k = 0; k < a.Columns; k++)
                        result[i, j] += a[i, k] * b[k, j];

            return result;
        }

        public static RealMatrix operator /(RealMatrix a, RealMatrix b)
        {
            if (a.Rows != b.Rows || a.Columns != b.Columns)
                throw new InvalidOperationException("Размеры матриц должны совпадать.");

            RealMatrix result = new RealMatrix(a.Rows, a.Columns);
            for (int i = 0; i < a.Rows; i++)
                for (int j = 0; j < a.Columns; j++)
                    result[i, j] = a[i, j] / b[i, j];
            return result;
        }

        public void MultiplyAssign(double scalar)
        {
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                    data[i, j] *= scalar;
        }

        public void DivideAssign(double scalar)
        {
            if (scalar == 0)
                throw new DivideByZeroException();
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                    data[i, j] /= scalar;
        }

        public static RealMatrix operator ^(RealMatrix a, int power)
        {
            if (a.Rows != a.Columns)
                throw new InvalidOperationException("Матрица должна быть квадратной.");

            if (power < 0)
                throw new ArgumentException("Степень должна быть неотрицательной.");

            RealMatrix result = Identity(a.Rows);
            RealMatrix baseMatrix = a.Clone();

            while (power > 0)
            {
                if ((power & 1) == 1)
                    result = result * baseMatrix;
                baseMatrix = baseMatrix * baseMatrix;
                power >>= 1;
            }

            return result;
        }

        public static RealMatrix Identity(int size)
        {
            RealMatrix identity = new RealMatrix(size, size);
            for (int i = 0; i < size; i++)
                identity[i, i] = 1.0;
            return identity;
        }

        // Печать матрицы
        public void Print()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                    Console.Write($"{data[i, j],8:F2} ");
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Создание матрицы A:");
            RealMatrix A = new RealMatrix(2, 2);
            A[0, 0] = 1; A[0, 1] = 2;
            A[1, 0] = 3; A[1, 1] = 4;
            A.Print();

            Console.WriteLine("\nМатрица A * 2:");
            RealMatrix B = A * 2;
            B.Print();

            Console.WriteLine("\nМатрица A / 2:");
            RealMatrix C = A / 2;
            C.Print();

            Console.WriteLine("\nМатрица A ^ 2:");
            RealMatrix D = A ^ 2;
            D.Print();

            Console.WriteLine("\nМатрица A *= 3:");
            A.MultiplyAssign(3);
            A.Print();

            Console.WriteLine("\nСоздание матрицы E:");
            RealMatrix E = new RealMatrix(2, 2);
            E[0, 0] = 2; E[0, 1] = 2;
            E[1, 0] = 6; E[1, 1] = 8;
            E.Print();

            Console.WriteLine("\nМатрица A / E:");
            RealMatrix F = A / E;
            F.Print();

            Console.WriteLine("\nДоступ к элементу F[1, 0]:");
            Console.WriteLine($"F[1, 0] = {F[1, 0]}");
        }
    }
}
