using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1
{
    public abstract class Figure
    {
        public abstract void Draw();

    }

    class Rectangle : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("I`m Rectangle!");
        }

    }

    class Square : Figure
    {
        
        public override void Draw()
        {
            Console.WriteLine("I`m Square!");
        }

    }
    





    class Program
    {
        static void Main(string[] args)
        {
            Square obj1 = new Square();
            Rectangle obj2 = new Rectangle();
            obj1.Draw();
            obj2.Draw();

            Console.ReadLine();
        }
    }
}
