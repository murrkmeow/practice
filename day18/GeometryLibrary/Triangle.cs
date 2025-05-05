using System;

namespace GeometryLibrary
{
    public class Triangle 
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public bool IsValid()
        {
            return (SideA + SideB > SideC) && (SideA + SideC > SideB) && (SideB + SideC > SideA);
        }

        public double GetPerimeter()
        {
            return IsValid() ? (SideA + SideB + SideC) : 0;
        }

        public double GetArea()
        {
            if (!IsValid()) return 0;
            double s = GetPerimeter() / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public string GetTriangleType()
        {
            if (!IsValid()) return "невозможный";
            if (SideA == SideB && SideB == SideC) return "равносторонний";
            if (SideA == SideB || SideB == SideC || SideA == SideC) return "равнобедренный";
            return "произвольный";
        }
    }
}


