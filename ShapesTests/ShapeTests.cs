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
    }
}