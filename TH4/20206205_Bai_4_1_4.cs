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
            int n = arr.Length;
            Console.WriteLine("Các phần tử mảng đang xét là:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
            }
            int[] brr = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        brr[i] += 1;
                    }
                }

            }
            int max = 1;
            for (int i = 0; i < n; i++)
            {
                if (brr[i] > max)
                {
                    max = brr[i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (brr[i] == max)
                {
                    Console.WriteLine("Phần tử {0} xuất hiện nhiều nhất trong mảng với số lần là: {1} lần!", arr[i], brr[i]);
                }
            }
            Console.WriteLine("Nhấn phím bất kì kết thúc chương trình.");
            Console.ReadKey();
        }
    }
}