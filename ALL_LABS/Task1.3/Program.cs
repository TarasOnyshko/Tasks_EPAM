using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_1._3
{

    class Circle
    {
        const double PI = 3.14;

        public double Length(double r)
        {
            return 2 * PI * r;
        }
        public double Square(double r)
        {
            return PI * r * r;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius:");
            double r = Convert.ToDouble(Console.ReadLine());

            Circle my_circcle = new Circle();


            Console.WriteLine("Results:");
            Console.WriteLine("Length = " + my_circcle.Length(r));
            Console.WriteLine("Square = " + my_circcle.Square(r));



            Console.ReadLine();



        }
    }
}
