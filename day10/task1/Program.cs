namespace task1
{
    internal class Program
    {
        static void Main()
        {
            TestClass obj = new TestClass(1); 

            obj.IxF0(0);
            obj.IxF1();

            obj.F0(0);
            obj.F1();

            ((Iz)obj).F0(0);
            ((Iz)obj).F1();

            Iy iy = obj;
            iy.F0(0);
            iy.F1();

            Iz iz = obj;
            iz.F0(0);
            iz.F1();
        }
    }
}
