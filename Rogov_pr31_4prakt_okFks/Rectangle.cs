using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rogov_pr31_4prakt_okFks
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(string width, string height)
        {
            CheckNumbers(width, height, out double checkedWidth, out double checkedHeight);
            CheckPositive(checkedWidth, checkedHeight);

            Width = checkedWidth;
            Height = checkedHeight;
        }

        public override double Area() => Width * Height;
        public override double Perimeter() => 2 * (Width + Height);
        public override string ToString() => $"Ширина = {Width} Высота = {Height}";

        private void CheckPositive(double width, double height)
        {
            if (width <= 0 || height <= 0) throw new Exception("Стороны должны быть положительными");
        }

        private void CheckNumbers(string width, string height, out double checkedWidth, out double checkedHeight)
        {
            if (!(double.TryParse(width, out checkedWidth))) throw new Exception("Слишком большие данные");
            if (!(double.TryParse(height, out checkedHeight))) throw new Exception("Слишком большие данные");
        }
    }
}
