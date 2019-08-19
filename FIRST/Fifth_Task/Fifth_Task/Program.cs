using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifth_Task
{
   
    class ComplexNumber
    {
        #region Complex number data
        public double r { get; set; }      //real part
        public double i { get; set; }     //imaginary part
        #endregion

        #region Multiplication Overload
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber res = new ComplexNumber();
            res.r = a.r * b.r - a.i * b.i;
            res.i = a.r * b.i + a.i * b.r;

            return res;
        }
        #endregion

        #region Division Overload
        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber res = new ComplexNumber();
            res.r = (a.r * b.r + a.i * b.i) / (b.r * b.r + b.i * b.i);
            res.i = (a.i * b.r - a.r * b.i) / (b.r * b.r + b.i * b.i);

            return res;
        }
        #endregion

        #region Write complex number function
        public void Print()
        {
            Console.Write("{0} + {1}i", this.r, this.i);
        }
        #endregion
    }


    class Program
    {
        static void Main(string[] args)
        {
            double r1, i1, r2, i2;
            ComplexNumber z1 = new ComplexNumber();
            ComplexNumber z2 = new ComplexNumber();

            Console.WriteLine("--- Comlex number A ---");
            Console.Write("Enter REAL part:");
            r1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter IMAGINARY part:");
            i1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("--- Comlex number B ---");
            Console.Write("Enter REAL part:");
            r2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter IMAGINARY part:");
            i2 = Convert.ToDouble(Console.ReadLine());

            z1.r = r1;
            z1.i = i1;
            z2.r = r2;
            z2.i = i2;

            ComplexNumber res = z1 * z2;

            Console.WriteLine();
            Console.Write("Multiplacation (A*B) = ");
            res.Print();

            res = z1 / z2;

            Console.WriteLine();
            Console.Write("Division (A/B) = ");
            res.Print();

            Console.ReadLine();


        }
    }
}
