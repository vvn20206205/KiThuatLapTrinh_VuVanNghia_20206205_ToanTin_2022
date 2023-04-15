//Vũ Văn Nghĩa_20206205
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace KiThuatLapTrinh
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Tạo sẵn mảng
            int[] arr = { 1, 6, 2, 7, 3, 8, 4, 5, 6, 9 };
            int KiemTraGiaTri = 5;
            int n = arr.Length;
            Console.WriteLine("Các phần tử mảng đang xét là:");
            int Kt = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
                if (arr[i] == KiemTraGiaTri)
                {
                    Kt++;
                }
            }
            if (Kt > 0)
            {
                Console.WriteLine("Số cần tìm {0} có tồn tại trong mảng!", KiemTraGiaTri);
            }
            else
            {
                Console.WriteLine("Số cần tìm {0} không tồn tại trong mảng!", KiemTraGiaTri);
            }
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }
            Console.WriteLine("Max = {0}", max);
            Console.WriteLine("Min = {0}", min);
            Console.WriteLine("Nhấn phím bất kì kết thúc chương trình.");
            Console.ReadKey();
        }
    }
}
