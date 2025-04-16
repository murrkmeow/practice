using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class A
    {
        int a;
        int b;

        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public double Calc(int a, int b)
        {
            return (-b + 1 / a) / 3;
        }

        public double Construction(int a, int b)
        {
            return Math.Pow(a + b, 3);
        }
    }
}
