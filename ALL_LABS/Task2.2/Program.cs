using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{


    public abstract class Figure
    {
        double X { get; }
        double Y { get; }
        public abstract void Draw();

        public Figure(double a, double b)
        {
            this.X = a;
            this.Y = b;

        }








    }

    class Rectangle : Figure
    {

        public override void Draw()
        {
            Console.WriteLine("I`m Rectangle!");

        }

        public Rectangle(double a, double b) : base(a, b)
        { }

    }

    class Square : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("I`m Square!");
        }

        public Square(double a, double b) : base(a, b)
        { }

    }




    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.Write("Enter X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y:");
            y = Convert.ToDouble(Console.ReadLine());


            Figure obj1 = new Square(x, y);
            Rectangle obj2 = new Rectangle(x, y);
            obj1.Draw();
            obj2.Draw();


            Console.ReadLine();

        }
    }
}
