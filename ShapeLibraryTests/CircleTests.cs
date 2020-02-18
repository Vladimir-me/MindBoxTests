using ShapeLibrary;
using System;
using Xunit;

namespace ShapeLibraryTests
{
    public class CircleTests
    {
        [Fact]
        public void ShouldBeInitializedProperly()
        {
            var circle = new Circle(10);

            Assert.Equal(10, circle.Radius);
        }

        [Theory]
        [InlineData(1, 3.14)]
        [InlineData(2, 12.56)]
        [InlineData(3, 28.26)]
        public void ShouldCalculateArea(double radius, double area)
        {
            var circle = new Circle(radius);

            Assert.Equal(area, circle.GetArea(), 1);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-20)]
        [InlineData(-300)]
        public void ShouldThrowException(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}
