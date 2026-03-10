using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rogov_pr31_4prakt_okFks
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(string a, string b, string c)
        {
            CheckNumbers(a, b, c, out double checkedA, out double checkedB, out double checkedC);
            CheckPositive(checkedA, checkedB, checkedC);
            TriangleExists(checkedA, checkedB, checkedC);

            SideA = checkedA;
            SideB = checkedB;
            SideC = checkedC;
        }

        public override double Perimeter() => SideA + SideB + SideC;
        public override double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        public override string ToString() => $"Сторона A = {SideA}  Сторона B = {SideB}  Сторона C = {SideC}";

        private void CheckPositive(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0) throw new Exception("Стороны треугольника должны быть положительными");
        }
        private void CheckNumbers(string a, string b, string c, out double checkedA, out double checkedB, out double checkedC)
        {
            if (!double.TryParse(a, out checkedA)) throw new Exception("Некорректное значение стороны A");

            if (!double.TryParse(b, out checkedB)) throw new Exception("Некорректное значение стороны B");

            if (!double.TryParse(c, out checkedC)) throw new Exception("Некорректное значение стороны C");
        }
        private void TriangleExists(double a, double b, double c)
        {
            if (!(a + b > c) && (a + c > b) && (b + c > a)) throw new Exception("Такой треугольник не существует");
        }
    }
}