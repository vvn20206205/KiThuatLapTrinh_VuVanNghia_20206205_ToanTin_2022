//Vũ Văn Nghĩa_20206205
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace KiThuatLapTrinh
{
    class Complex
    {
        private int Real { get; set; }
        private int Img { get; set; }
        public Complex() { }
        public Complex(int real, int img)
        {
            Real = real;
            Img = img;
        }
        public static Complex operator +(Complex a, Complex b)
        {
            Complex c = new Complex();
            c.Real = a.Real + b.Real;
            c.Img = a.Img + b.Img;
            return c;
        }
        public static Complex operator -(Complex a, Complex b)
        {
            Complex c = new Complex();
            c.Real = a.Real - b.Real;
            c.Img = a.Img - b.Img;
            return c;
        }
        public static Complex operator *(Complex a, Complex b)
        {
            Complex c = new Complex();
            c.Real = a.Real * b.Real - a.Img * b.Img;
            c.Img = a.Real * b.Img + a.Img * b.Real;
            return c;
        }
        public override string ToString()
        {
            return Convert.ToString(this.Real) + "+" + Convert.ToString(this.Img) + "i";
        }
        public void Display()
        {
            Console.WriteLine("{0} + {1}i", Real, Img);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Complex x = new Complex(12, 23);
            Console.Write("x = "); x.Display();
            Complex y = new Complex(62, 51);
            Console.Write("y = "); y.Display();
            Complex z1 = new Complex(); z1 = x + y;
            Complex z2 = new Complex(); z2 = x - y;
            Complex z3 = new Complex(); z3 = x * y;
            Console.Write("x + y = "); z1.Display();
            Console.Write("x - y = "); z2.Display();
            Console.Write("x * y = "); z3.Display();
            Console.WriteLine("Nhấn phím bất kì kết thúc chương trình.");
            Console.ReadKey();
        }
    }
}