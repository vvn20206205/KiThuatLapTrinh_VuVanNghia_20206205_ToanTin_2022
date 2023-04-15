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
            Console.WriteLine("Bài toán n quân hậu.");
            int n;
            bool kt = false;
            do
            {
                Console.WriteLine("Nhập kích thước của bàn cờ nxn");
                Console.Write("Nhập số nguyên dương n = ");
                string nNhap = Console.ReadLine();
                kt = int.TryParse(nNhap, out n);
            } while (!kt || n <= 0);
            XuLi(1, n);
            Console.WriteLine("Nhấn phím bất kì kết thúc chương trình.");
            Console.ReadKey();

        }
        public static int[] a = new int[100];
        // Hàm kiểm tra điều kiện quân hậu thỏa mãn
        public static bool Ok(int x2, int y2)
        {
            for (int i = 1; i < x2; i++)
                if (a[i] == y2 || Math.Abs(i - x2) == Math.Abs(a[i] - y2))
                    return false;
            return true;
        }
        // Hàm xuất output quân hậu thỏa mãn

        public static void Xuat(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(a[i]);

            }
            Console.Write("\n");
        }
        // Hàm đệ qui xử lí bài toán

        public static void XuLi(int i, int n)
        {
            for (int j = 1; j <= n; j++)
            {
                if (Ok(i, j))
                {
                    a[i] = j;
                    if (i == n)
                    {
                        Xuat(n);
                    }
                    XuLi(i + 1, n);
                }
            }
        }
    }
}