using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctionProgram
{
    public class Rectangle
    {
        public int length, width, area;
        public Rectangle(int length, int width )
        {
            this.length = length;
            this.width = width;
        }
        public void AreaOfRectangle()
        {
            area = length * width;
            Console.WriteLine( area );
        }
    }
}
