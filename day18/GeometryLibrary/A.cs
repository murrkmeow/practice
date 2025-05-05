using System.Globalization;

namespace GeometryLibrary
{ 
    public class A
    {
        private int a;
        private int b;

        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public double ModuloAssign()
        {
            return a %= b;
        }

        public int Sum()
        {
            return a + b;
        }
    }
}


