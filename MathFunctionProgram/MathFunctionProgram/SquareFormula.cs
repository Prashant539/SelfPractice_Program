using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctionProgram
{
    public class SquareFormula
    {
        public int a, b, square;
        public SquareFormula(int a, int b)
        {
            this.a = a;
            this.b = b;
            
        }
        public void SquareOfTwoNumber()
        {
            int square = (a*a + b*b + 2*a*b);
            Console.WriteLine("Square of two number:" +square);
        }
    }
}
