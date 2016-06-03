using System;

namespace TDD_Area
{
    public class Circle
    {
        public double Radius { get; set; }   

        public Circle()
        {
        }

        public Circle(double radius) : this()
        {
            Radius = radius;
        }

        public double CalculateSum()
        {
            return Math.Round((Radius * 
                Radius) * Math.PI, 2);
        }
    }
}
