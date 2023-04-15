//Vũ Văn Nghĩa_20206205
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace KiThuatLapTrinh
{
    public static class Program
    {
        static unsafe void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Tạo sẵn mảng
            int[] arr = { 1, 6, 2, 7, 3, 8, 4, 5, 6, 9 };
            int n = arr.Length;
            fixed (int* ptr = arr)
                for (int i = n - 1; i > -1; i--)
                {
                    Console.WriteLine("Giá trị của arr[{0}]={1}", i, *(ptr + i));
                }
            Console.WriteLine("Nhấn phím bất kì kết thúc chương trình.");
            Console.ReadKey();
        }
    }
}