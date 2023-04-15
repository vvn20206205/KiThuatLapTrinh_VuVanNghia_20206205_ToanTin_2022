//Vũ Văn Nghĩa_20206205
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace KiThuatLapTrinh
{
    public static class Program
    {
        public unsafe static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int tong = 0;
            int[] arr = { 10, 100, 200 };
            int n = arr.Length;
            fixed (int* ptr = arr)
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Giá trị của arr[{0}]={1}", i, *(ptr + i));
                    tong = tong + (*(ptr + i));
                }
            Console.WriteLine("Tổng của Mảng ={0}", tong);
            Console.WriteLine("Nhấn phím bất kì kết thúc chương trình.");
            Console.ReadKey();
        }
    }
}