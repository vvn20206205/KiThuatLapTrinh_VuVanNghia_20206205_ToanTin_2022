//Vũ Văn Nghĩa_20206205
using System;
using System.IO;
using System.Text;
namespace KiThuatLapTrinh
{
    class Program
    {
        public static int n;
        public static int[] kq = new int[11];
        public static int[] dd = new int[10];
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Bài toán liệt kê hoán vị.");
            bool kt = false;
            do
            {
                Console.Write("Nhập số nguyên dương n = ");
                string nNhap = Console.ReadLine();
                kt = int.TryParse(nNhap, out n);
            } while (!kt || n <= 0);
            Console.WriteLine("\nCác hoán vị từ 1 tới {0} là: ", n);
            for (int i = 1; i <= 9; i++)
            {
                dd[i] = 0;
            }
            LietKeHoanVi(1);
            Console.WriteLine("Nhấn phím bất kì kết thúc chương trình.");
            Console.ReadKey();
        }
        public static void xuat()
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write("{0} ", kq[j]);
            }
            Console.Write("\n");
        }
        public static void LietKeHoanVi(int i)
        {
            if (i > n)
                xuat();
            for (int j = 1; j <= n; j++)
            {
                if (dd[j] == 0)
                {
                    dd[j] = 1;
                    kq[i] = j;
                    LietKeHoanVi(i + 1);
                    dd[j] = 0;
                }
            }
        }
    }
}