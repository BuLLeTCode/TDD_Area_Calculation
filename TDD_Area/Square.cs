using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Area
{
    public class Square
    {
        public double Side { get; set; }

        public Square()
        {
        }

        public Square(double side) : this()
        {
            Side = side;
        }

        public double CalculateSum()
        {
            return Side * Side;
        }
    }
}
