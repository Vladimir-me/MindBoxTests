using System;

namespace ShapeLibrary
{
    public class Triangle : IShape
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA < 0)
            {
                throw new ArgumentException("SideA cannot be negative");
            }
            if (sideB < 0)
            {
                throw new ArgumentException("SideB cannot be negative");
            }
            if (sideC < 0)
            {
                throw new ArgumentException("SideC cannot be negative");
            }
            if (sideA > sideB + sideC)
            {
                throw new ArgumentException("SideA cannot be greater than sum of sideA and sideB");
            }
            if (sideB > sideA + sideC)
            {
                throw new ArgumentException("SideB cannot be greater than sum of sideA and sideB");
            }
            if (sideC > sideA + sideB)
            {
                throw new ArgumentException("SideC cannot be greater than sum of sideA and sideB");
            }
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public bool IsRightAngled
        {
            get
            {
                var maxSide = Math.Max(SideA, Math.Max(SideB, SideC));
                if (SideA == maxSide)
                {
                    return Math.Pow(SideA, 2) == Math.Pow(SideB, 2) + Math.Pow(SideC, 2);
                }
                else if (SideB == maxSide)
                {
                    return Math.Pow(SideB, 2) == Math.Pow(SideA, 2) + Math.Pow(SideC, 2);
                }
                return Math.Pow(SideC, 2) == Math.Pow(SideA, 2) + Math.Pow(SideB, 2);
            }
        }

        public double GetArea()
        {
            var p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
    }
}

