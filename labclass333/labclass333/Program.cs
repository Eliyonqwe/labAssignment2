using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labclass333
{   
    //internal, { set; get; }, interface(schema provide endiyaderg), 
   
    abstract class shape
    {
        double CalculateArea();
        double CalculatePerimeter();

    }

    class circle extends class shape{ 
        public double radius { get; set; };
        static double PI = 3.14;
        double CalculateArea()
        {

        }
        double CalculatePerimeter()
        {

        }
    }

    class rectange extends class shape
    {
        double length;
        double width;
        double CalculateArea()
        {

        }
        double CalculatePerimeter()
        {

        }
    }
    internal class Program
   
    {
        static void Main(string[] args)
        {
        }
    }
}
