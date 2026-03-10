using System;
using Xunit;
using Rogov_pr31_4prakt_okFks;

namespace ShapesTests
{
    public class ShapeTests
    {

        [Fact]
        public void Rectangle_Create_Success()
        {
            var rect = new Rectangle("5,5", "8");

            Assert.Equal(5.5, rect.Width);
            Assert.Equal(8.0, rect.Height);
        }

        [Fact]
        public void Triangle_Create_Success()
        {
            var tri = new Triangle("3", "4", "5");

            Assert.Equal(3.0, tri.SideA);
            Assert.Equal(4.0, tri.SideB);
            Assert.Equal(5.0, tri.SideC);
        }

        [Fact]
        public void Rectangle_Area_CorrectCalculation()
        {
            var rect = new Rectangle("4", "7,5");

            double area = rect.Area();
            Assert.Equal(30.0, area);
        }

        [Fact]
        public void Rectangle_Perimeter_CorrectCalculation()
        {
            var rect = new Rectangle("10", "6");

            double perimeter = rect.Perimeter();
            Assert.Equal(32.0, perimeter);
        }

        [Fact]
        public void Rectangle_Constructor_NegativeWidth()
        {
            Assert.Throws<Exception>(() => new Rectangle("-5", "10"));
        }

        [Fact]
        public void Rectangle_Constructor_ZeroHeight()
        {
            Assert.Throws<Exception>(() => new Rectangle("8", "0"));
        }
        [Fact]
        public void Triangle_Constructor_NegativeSide()
        {
            Assert.Throws<Exception>(() => new Triangle("5", "-3", "4"));
        }

        [Fact]
        public void Triangle_Constructor_NotANumber()
        {
            Assert.Throws<Exception>(() => new Triangle("7", "abc", "9"));
        }

        [Fact]
        public void Triangle_Constructor_NotExists()
        {
            Assert.Throws<Exception>(() => new Triangle("2", "3", "6"));
        }

        [Fact]
        public void Triangle_Area_RightTriangle()
        {
            var t = new Triangle("3", "4", "5");
            Assert.Equal(6.0, t.Area());
        }

        [Fact]
        public void Triangle_Perimeter_3_4_5_Returns12()
        {
            var t = new Triangle("3", "4", "5");
            Assert.Equal(12.0, t.Perimeter());
        }
    }
}