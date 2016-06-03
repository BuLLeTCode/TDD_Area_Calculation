namespace TDD_Area
{
    public class Triangle
    {
        public double TriangleBase { get; set; }
        public double TriangleHeight { get; set; }

        public Triangle()//Practice says, it`s good to define default constructor
        {
        }

        public Triangle(double triangleBase, double triangleHeight) : this()
        {
            TriangleBase = triangleBase;
            TriangleHeight = triangleHeight;
        }

        public double CalculateSum()
        {
            return TriangleBase * TriangleHeight / 2;
        }
    }
}
