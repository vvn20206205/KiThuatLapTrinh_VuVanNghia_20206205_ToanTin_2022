//Vũ Văn Nghĩa_20206205
using System;
using System.Text;
namespace KiThuatLapTrinh
{
    public static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n; bool kt = false;
            do
            {
                Console.Write("Nhập số n: ");
                string nNhap = Console.ReadLine();
                kt = int.TryParse(nNhap, out n);
            } while (!kt);
            int SntTest = KiemTraSoNguyenTo(n);
            if (SntTest == 1)
            {
                Console.Write("{0} là số nguyên tố", n);
            }
            else
            {
                Console.Write("{0} không là số nguyên tố", n);
            }
            Console.WriteLine("\nNhấn phím bất kì để tiếp tục!");
            Console.ReadKey();
        }
        public static int KiemTraSoNguyenTo(int x)
        {
            if (x <= 1) return 0;
            for (int j = 2; j <= Math.Sqrt(x); j++)
            {
                if (x % j == 0) return 0;
            }
            return 1;
        }
    }
}
