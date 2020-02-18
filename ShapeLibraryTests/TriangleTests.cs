using ShapeLibrary;
using System;
using Xunit;

namespace ShapeLibraryTests
{
    public class TriangleTests
    {
        [Fact]
        public void ShouldBeInitializedProperly()
        {
            var triangle = new Triangle(10, 20, 25);

            Assert.Equal(10, triangle.SideA);
            Assert.Equal(20, triangle.SideB);
            Assert.Equal(25, triangle.SideC);
        }

        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(10, 10, 10, 43.3)]
        [InlineData(12, 13, 14, 72.3)]
        public void ShouldCalculateArea(double a, double b, double c, double area)
        {
            var triangle = new Triangle(a, b, c);

            Assert.Equal(area, triangle.GetArea(), 1);
        }

        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(10, 10, 10, false)]
        [InlineData(10, 11, 12, false)]
        public void ShouldDetermineIfRightAngled(double a, double b, double c, bool rightAngled)
        {
            var triangle = new Triangle(a, b, c);

            Assert.Equal(rightAngled, triangle.IsRightAngled);
        }

        [Fact]
        public void ShouldThrowExceptions()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-1, 1, 1));
            Assert.Throws<ArgumentException>(() => new Triangle(1, -1, 1));
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, -1));
            Assert.Throws<ArgumentException>(() => new Triangle(10, 1, 1));
            Assert.Throws<ArgumentException>(() => new Triangle(1, 10, 1));
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 10));
        }
    }
}
