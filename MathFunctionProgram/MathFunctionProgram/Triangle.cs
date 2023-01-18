using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctionProgram
{
    public class Triangle
    {
        public int side1, side2, side3, semiperimeter, area;
        public Triangle(int side1, int side2, int side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public void AreaOfTraingle()
        {
            double semiperimeter = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
            Console.WriteLine("Area of Triangle:" + area);
        }
            
    }
}
