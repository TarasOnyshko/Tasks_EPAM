using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_1._2
{

    class Rectangle
    {
        private double a, b;

        public Rectangle(double x1, double y1, double x2, double y2)
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

        }

        public double Perimeter { get { return 2 * (a + b); } }
        public double Square { get { return a * b; } }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2;

            Console.Write("Enter x1:");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y1:");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter x2:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y2:");
            y2 = Convert.ToDouble(Console.ReadLine());

            Rectangle my_rectangle = new Rectangle(x1, y1, x2, y2);

            Console.WriteLine();

            Console.WriteLine("Perimetr = " + my_rectangle.Perimeter);
            Console.WriteLine("Square = " + my_rectangle.Square);

            Console.ReadLine();
        }
    }
}
