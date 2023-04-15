//Vũ Văn Nghĩa_20206205
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace KiThuatLapTrinh
{
    public static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a, b;
            bool kt = false;
            do
            {
                Console.Write("Nhập số thứ nhất: ");
                string nNhap = Console.ReadLine();
                kt = int.TryParse(nNhap, out a);
            } while (!kt);
            kt = false;
            do
            {
                Console.Write("Nhập số thứ hai: ");
                string nNhap = Console.ReadLine();
                kt = int.TryParse(nNhap, out b);
            } while (!kt);
            int KetQua = UCLN(a, b);
            Console.WriteLine("UCLN của {0} và {1} là : {2}",a,b,KetQua);
            KetQua = BCNN(a, b);
            Console.WriteLine("BCNN của {0} và {1} là : {2}",a,b,KetQua);
            Console.WriteLine("\nNhấn phím bất kì để tiếp tục!");
            Console.ReadKey();
        }
        public static int UCLN(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a; // or return b; a = b
        }
        public static int BCNN(int a, int b)
        {
            int result = UCLN(a, b);
            return a * b / result;
        }
    }
}