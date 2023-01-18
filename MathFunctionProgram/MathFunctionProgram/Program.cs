using System;
namespace MathFunctionProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Math Based Program ");
            Console.WriteLine("Choose any option to perform");
            Console.WriteLine("1:Reactangle\n2:Triangle\n3:Celsius");
            int options = Convert.ToInt32(Console.ReadLine());
            switch(options)
            {
                case 1:
                    Console.WriteLine("please choose the length");
                    int length = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please choose the width");
                    int width = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Print the Area of Rectangle");
                    Rectangle rectangle = new Rectangle(width, length);
                    rectangle.AreaOfRectangle();
                    break;
                case 2:
                    Console.WriteLine("Please choose side 1: ");
                    int side1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please choose side 2: ");
                    int side2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please choose side 3: ");
                    int side3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Print the Area of Triangle");
                    Triangle triangle = new Triangle(side1, side2, side3);
                    triangle.AreaOfTraingle();
                    break;
                case 3:
                    Console.WriteLine("Please choose degree in celsius: ");
                    int celsius = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please choose a fahreheit");
                    int fahreheit = Convert.ToInt32(Console.ReadLine());
                    Celsius celsius1 = new Celsius(celsius, fahreheit);
                    celsius1.CelsiusToFahreheit();
                    break;

                         
                default:
                    Console.WriteLine("choose valid number");
                    break;



            }
           
            

        }
    }
}
