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
            int[] Mang = { 1, 2, 3, 2, 4, 8, 7, 8, 3, 9 };
            XuatMang(Mang);
            int M = 14;
            Console.WriteLine("Số nguyên M là: " + M);
            HamTimMangCon(Mang, M);
            Console.WriteLine("Nhấn phím bất kì kết thúc chương trình.");
            Console.ReadKey();
        }
        // Hàm xuất mảng
        static void XuatMang(int[] Mang)
        {
            Console.WriteLine("Mảng cần xét là:");
            for (int i = 0; i < Mang.Length; i++)
            {
                Console.Write("{0} ", Mang[i]);
            }
            Console.Write("\n");
        }
        // Hàm tìm 1 mảng con sao cho tổng các phần tử bằng M
        public static void HamTimMangCon(int[] Mang, int M)
        {
            int n = Mang.Length, dem = 0;
            for (int i = 0; i < n; i++)
            {
                int Sum = 0;
                for (int j = i; j < n; j++)
                {
                    Sum += Mang[j];
                    if (Sum == M)
                    {
                        Console.Write("Mảng con cần tìm là:");
                        for (int k = i; k <= j; k++)
                        {
                            Console.Write(" " + Mang[k]);
                        }
                        Console.Write("\n");
                        break;
                    }
                    else
                    {
                        dem++;
                    }

                }
            }
            // Nếu xét hết trường hợp mà không tìm được
            if (dem == n * (n + 1) / 2)
            {
                Console.WriteLine("Không có mảng con thỏa mãn bài toán!");

            }

        }
    }
}