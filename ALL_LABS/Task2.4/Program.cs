using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._4
{

    interface IDrawable
    {
        void Draw();

    }


    public class Figure : IDrawable
    {
        double X { get; }
        double Y { get; }


        public Figure(double a, double b)
        {
            this.X = a;
            this.Y = b;

        }

        public void Draw()
        {
            Console.WriteLine("I`m Figure!");

        }
    }

    class Rectangle : Figure, IDrawable
    {

        public void Draw()
        {
            Console.WriteLine("I`m Rectangle!");

        }

        public Rectangle(double a, double b) : base(a, b)
        { }

    }

    class Square : Figure, IDrawable
    {
        public void Draw()
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
            Figure obj3 = new Figure(x, y);

            DrawAll(obj1, obj2, obj3);

            Console.ReadLine();
        }



        private static void DrawAll(params IDrawable[] array)
        {
            foreach (var x in array)
            {
                x.Draw();

            }
        }
    }
}
