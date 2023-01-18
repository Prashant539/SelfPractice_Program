using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctionProgram
{
    public class Celsius
    {
        public int celsius, fahreheit;
        public Celsius(int celsius, int fahreheit)
        {
            this.celsius = celsius;
            this.fahreheit = fahreheit;
        }
        public void CelsiusToFahreheit()
        {
            float fahreheit = ((celsius * 9) / 5) + 32;
            Console.WriteLine("Convert celsius to Fahrenhit:" + fahreheit);
        }
    }
}
