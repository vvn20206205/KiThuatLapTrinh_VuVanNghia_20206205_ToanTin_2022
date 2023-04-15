//Vũ Văn Nghĩa_20206205
using System;
using System.IO;
using System.Text;
namespace KiThuatLapTrinh
{
    class Program
    {
        public static int n, a, b, dem = 0;
        public static int[,] A = new int[50, 50];
        public static int[] X = { -2, -2, -1, -1, 1, 1, 2, 2 };
        public static int[] Y = { -1, 1, -2, 2, -2, 2, -1, 1 };
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Bài toán mã đi tuần.");
            bool kt = false;
            do
            {
                Console.Write("Nhập số nguyên dương n = ");
                string nNhap = Console.ReadLine();
                kt = int.TryParse(nNhap, out n);
            } while (!kt || n <= 0);
            kt = false;
            do
            {
                Console.Write("Nhập vị trí bắt đầu x = ");
                string nNhap = Console.ReadLine();
                kt = int.TryParse(nNhap, out a);
            } while (!kt);
            kt = false;
            do
            {
                Console.Write("Nhập vị trí bắt đầu y = ");
                string nNhap = Console.ReadLine();
                kt = int.TryParse(nNhap, out b);
            } while (!kt);
            diChuyen(a, b);
            Console.WriteLine("Không tìm thấy đường đi");
            Console.WriteLine("Nhấn phím bất kì kết thúc chương trình.");
            Console.ReadKey();
        }
        // Hàm xuất kết quả thỏa mãn
        public static void xuat()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", A[i, j]);
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        // Hàm đệ qui xử lí bài toán
        public static void diChuyen(int x, int y)
        {
            ++dem;
            A[x, y] = dem;
            for (int i = 0; i < 8; i++)
            {
                if (dem == n * n)
                {
                    Console.WriteLine("Các bước đi là:");
                    xuat();
                    Environment.Exit(1);
                }
                int u = x + X[i];
                int v = y + Y[i];
                if (u >= 0 && u < n && v >= 0 && v < n && A[u, v] == 0)
                {
                    diChuyen(u, v);
                }
            }
            --dem;
            A[x, y] = 0;
        }
    }
}