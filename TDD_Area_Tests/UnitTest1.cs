using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Area;

namespace TDD_Area_Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private readonly Calculator _calc = new Calculator();

        [TestMethod]
        public void GetTotalArea_NoParams_ReturnsZero()
        {
            Assert.AreEqual(0, _calc.GetTotalArea());
        }

        [TestMethod]
        public void GetTotalArea_OneTriangle_ReturnsTwelve()
        {
            Assert.AreEqual(12, _calc.GetTotalArea(new Triangle(6, 4)));
        }

        [TestMethod]
        public void GetTotalArea_OneSquare_ReturnsThirtySix()
        {
            Assert.AreEqual(36, _calc.GetTotalArea(new Square(6)));
        }

        [TestMethod]
        public void GetTotalArea_OneRectangle_ReturnsThirtyTwo()
        {
            Assert.AreEqual(32, _calc.GetTotalArea(new Rectangle(4, 8)));
        }

        [TestMethod]
        public void GetTotalArea_OneCircle_ReturnsTwentyEight()
        {
            Assert.AreEqual(28.27, _calc.GetTotalArea(new Circle(3)));
        }

        [TestMethod]
        public void GetTotalArea_DifferentShapes_ReturnsTwentyEight()
        {
            Assert.AreEqual(49.14, _calc.GetTotalArea(new Rectangle(4, 2), new Rectangle(3, 4), new Circle(1), new Square(1), new Triangle(10, 5)));
        }
    }
}
