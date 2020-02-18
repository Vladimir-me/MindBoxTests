using System;

namespace ShapeLibrary
{
    public class Circle : IShape
    {
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius cannot be negative");
            }
            Radius = radius;
        }

        public double Radius { get; }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
