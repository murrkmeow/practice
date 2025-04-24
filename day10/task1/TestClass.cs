namespace task1
{
    class TestClass : Ix, Iy, Iz
    {
        public int w;

        public TestClass(int w)
        {
            this.w = w;
        }

        public void IxF0(int param)
        {
            Console.WriteLine($"IxF0: {7 * w - 4}");
        }

        public void IxF1()
        {
            Console.WriteLine($"IxF1: {7 * w - 4}");
        }

        public void F0(int param)
        {
            Console.WriteLine($"Iy.F0: {w * 3}");
        }

        public void F1()
        {
            Console.WriteLine($"Iy.F1: {w * 3}");
        }

        void Iz.F0(int param)
        {
            Console.WriteLine($"Iz.F0: {6 + w}");
        }

        void Iz.F1()
        {
            Console.WriteLine($"Iz.F1: {6 + w}");
        }
    }
}
