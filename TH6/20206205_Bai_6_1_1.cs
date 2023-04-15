//Vũ Văn Nghĩa_20206205
using System;
using System.IO;
using System.Text;
namespace KiThuatLapTrinh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;
            bool kt = false;
            do
            {
                Console.Write("Nhập số nguyên dương n = ");
                string nNhap = Console.ReadLine();
                kt = int.TryParse(nNhap, out n);
            } while (!kt || n<0);
            Console.WriteLine("Fibonaci({0}) = {1}", n, Fibonaci(n));
            Console.WriteLine("Nhấn phím bất kì kết thúc chương trình.");
            Console.ReadKey();
        }
        // Hàm đệ qui tìm Fibonaci
        public static int Fibonaci(int n)
        {
            if (n==0)
            {
                return 0;
            }  if (n==1)
            {
                return 1;
            }
            else
            {
                return Fibonaci(n - 1) + Fibonaci(n - 2);
            }
        }
    }
}