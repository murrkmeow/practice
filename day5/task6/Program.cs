namespace task6
{
    internal class Program
    {
        static void GenException()
        {
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine()!);
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine()!);
            double f = 1;

            try 
            {
                for (double i = a; i <= b; ++i)
                {
                    try 
                    {
                        f *= i; 

                        if (Math.Abs(f - 1) < 0.000001) 
                            throw new DivideByZeroException("Произошло деление на слишком малое значение!");

                        Console.WriteLine("y({0})={1:f6}", i, 100 / (f - 1));
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine("y({0})= {1}", i, ex.Message);
                    }
                }
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("ERROR");
                throw; 
            }
        }

        static void Main()
        {
            try
            {
                GenException();
            }
            catch
            {
                Console.WriteLine("НЕИСПРАВИМАЯ ОШИБКА!!!");
            }
        }
    }

    //DivideByZeroException будет сгененрировано только в случае если a = 1 (в неиспраленной программе)
}
