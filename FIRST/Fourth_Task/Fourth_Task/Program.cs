using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_Task
{

    static class Rectangle
    {
        private static double a, b;     

        public static double Perimeter(double x1, double y1, double x2, double y2)
        {
            if (y1 > y2)
            {
                a = y1 - y2;
            }
            else if (y1 < y2)
            {
                a = y2 - y1;
            }


            if (x1 > x2)
            {
                b = x1 - x2;
            }
            else if (x1 < x2)
            {
                b = x2 - x1;
            }
            return 2 * (a + b);
        }

        public static double Square(double x1, double y1, double x2, double y2)
        {      
            return a * b;
        }
    }

    static class Circle
    {
        const double PI = 3.14;

        public static double Length(double r)
        {
            return 2 * PI * r;
        }
        public static double Square(double r)
        {
            return PI * r * r;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2;
            double r;

            Console.WriteLine("---For rectangle---");

            Console.Write("Enter x1:");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y1:");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter x2:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y2:");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("---For circle---");
            Console.Write("Enter radius:");
            r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Results:");

            Console.Write("Rectangel`s Perimeter = " + Rectangle.Perimeter(x1, y1, x2, y2) + "\t");
            Console.Write("Circle`s Length = " + Circle.Length(r) + "\n");

            Console.Write("Rectangel`s Square = " + Rectangle.Square(x1, y1, x2, y2) + "\t        ");
            Console.Write("Circle`Square = " + Circle.Square(r));

            Console.ReadLine();

        }
    }
}
