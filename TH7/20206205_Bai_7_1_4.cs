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
            int[] Mang = { 1, 2, 3, -4, 5, 6, 7, -8, 9 };
            XuatMang(Mang);
            XuLiBaiToan(Mang);
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
        // Hàm tìm dãy con toàn dương có tổng lớn nhất
        static void XuLiBaiToan(int[] Mang)
        {
            int TongMax = 0, Tong = 0, BatDau = 0, KetThuc = 0, Tam = 0;
            for (int i = 0; i < Mang.Length; i++)
            {
                if (Mang[i] > 0)
                {
                    Tong += Mang[i];
                }
                else
                {
                    if (Tong > TongMax)
                    {
                        TongMax = Tong;
                        KetThuc = i - 1;
                        BatDau = Tam;
                    }
                    Tong = 0; Tam = i + 1;
                }
            }
            Console.WriteLine("Tổng lớn nhất của dãy con toàn dương là: " + TongMax);
            Console.Write("Dãy con thỏa mãn là: ");
            for (int i = BatDau; i <= KetThuc; i++)
            {
                Console.Write(" " + Mang[i]);
            }
            Console.Write("\n");
        }
    }
}