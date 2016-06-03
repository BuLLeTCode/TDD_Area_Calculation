using System;

namespace TDD_Area
{
    public class Calculator
    {
        public double GetTotalArea()
        {
            return 0;
        }
        //Hope will do the job
        public double GetTotalArea(params object[] shapes)
        {
            double totalArea = 0;

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine("Shapes is:" + shapes[i].GetType());
                switch (shapes[i].GetType().ToString().Replace("TDD_Area.", ""))
                {
                    case "Triangle":
                        Triangle triangle = (Triangle)shapes[i];
                        totalArea += triangle.CalculateSum();
                        break;
                    case "Square":
                        Square square = (Square)shapes[i];
                        totalArea += square.CalculateSum();
                        break;
                    case "Rectangle":
                        Rectangle rectangle = (Rectangle)shapes[i];
                        totalArea += rectangle.CalculateSum();
                        break;
                    case "Circle":
                        Circle circle = (Circle)shapes[i];
                        totalArea += circle.CalculateSum();
                        break;
                }
            }

            return totalArea;
        }
    }
}
