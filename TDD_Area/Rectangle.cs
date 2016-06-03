using System;

namespace TDD_Area
{
    public class Rectangle
    {
        public double RectangleHeight { get; set; }
        public double RectangleWidth { get; set; }

        public Rectangle()
        {
        }

        public Rectangle(double rectangleHeight, double rectangleWidth) : this()
        {
            RectangleHeight = Math.Round(rectangleHeight, 2);
            RectangleWidth = Math.Round(rectangleWidth, 2);
        }

        public double CalculateSum()
        {
            return RectangleHeight*RectangleWidth;
        }
    }
}
