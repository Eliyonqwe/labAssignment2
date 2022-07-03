using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labclass333
{   
    
    internal class Program
     {

        public abstract class Shape
        {
            public abstract double CalculateArea();
            public abstract double CalculatePerimeter();

        }

        public class Circle : Shape
        {
            public double radius { get; set; }
            static double PI = 3.14;
            public override double CalculateArea()
            {
                return PI* radius * radius;
            }
            public override double CalculatePerimeter()
            {
                return 2 * PI * radius;
            }
        }

        public class Rectange : Shape
        {
            public double length { get; set; }
            public double width { get; set; }
            public override double CalculateArea()
            {
                return length * width;
            }
            public override double CalculatePerimeter()
            {
                return 2 * (length + width);
            }
        }


        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("---------------Area and Perimeter Calculator---------------");
                Console.WriteLine("1. Circle \n2. Rectangle");
                choice = Convert.ToInt16(Console.ReadLine());
                if (choice <= 0 || choice > 2)
                {
                    Console.WriteLine("Error: Invalid Input!");
                }
            } while (choice <= 0 || choice > 2);

            
            switch (choice) { 
                case 1:
                    Circle circle = new Circle();
                    Console.WriteLine("Enter radius of the circle: ");
                    circle.radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area of the Circle: " + circle.CalculateArea());
                    Console.WriteLine("Perimeter of the Circle: " + circle.CalculatePerimeter());
                    break;
                case 2:
                    Rectange rectangle = new Rectange();
                    Console.WriteLine("Enter Length of the Rectangle: ");
                    rectangle.length = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter width of the Rectangle: ");
                    rectangle.width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area of the Rectangle: " + rectangle.CalculateArea());
                    Console.WriteLine("Perimeter of the Rectangle: " + rectangle.CalculatePerimeter());
                    break;
            }
            Console.ReadKey();
        }

        }
    }

