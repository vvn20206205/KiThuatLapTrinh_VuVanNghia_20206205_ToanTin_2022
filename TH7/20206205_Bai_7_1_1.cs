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
            int[] Mang = { 1, 2, 3, 14, 15, 16, 27, 28, 29, 50 };
            XuatMang(Mang);
            Console.WriteLine("Khoảng cách trung bình giữa các giá trị trong mảng là: " + HamTinhKhoangCachTrungBinhGiuaCacGiaTriTrongMang(Mang));
            Console.WriteLine("Nhấn phím bất kì kết thúc chương trình.");
            Console.ReadKey();
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
            // Ham Tinh Khoang Cach Trung Binh Giua Cac Gia Tri Trong Mang
            static float HamTinhKhoangCachTrungBinhGiuaCacGiaTriTrongMang(int[] Mang)
            {
                int dem = 0, Tong = 0;
                for (int i = 0; i < Mang.Length - 1; i++)
                {
                    for (int j = i + 1; j < Mang.Length; j++)
                    {
                        int Tam = Math.Abs(Mang[i] - Mang[j]);
                        Tong += Tam;
                        dem++;
                    }
                }
                return Tong / (dem);
            }
        }
    }
}