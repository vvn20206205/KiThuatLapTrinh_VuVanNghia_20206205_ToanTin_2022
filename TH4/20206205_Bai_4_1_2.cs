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
            int[] arr = { 1, 6, 2, 7, 3, 8, 4, 5, 6};
            int KiemTraGiaTri = 15;
            int n = arr.Length;
            Console.WriteLine("Các phần tử mảng đang xét là:");
            for (int i = 0; i < n ; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
            }
                int tmp;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                    if (arr[i] < arr[j])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
            }
            Console.WriteLine("Mảng sau khi sắp xếp là: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
            }
            int kq = binarySearch(arr, 0, n - 1, KiemTraGiaTri);
            if (kq == -1)
            {
                Console.WriteLine("Số cần tìm {0} không tồn tại trong mảng!", KiemTraGiaTri);
            }
            else
            {
                Console.WriteLine("Số cần kiểm tra {0} ở vị trí thứ {1} của mảng đã sắp xếp!",KiemTraGiaTri, kq + 1);
            }
            Console.WriteLine("Nhấn phím bất kì kết thúc chương trình.");
            Console.ReadKey();
        }
        public static int binarySearch(int[] arr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;
                if (arr[mid] == x)
                {
                    return mid;
                }
                if (arr[mid] > x)
                {
                    return binarySearch(arr, l, mid - 1, x);
                }
                else
                {
                    return binarySearch(arr, mid + 1, r, x);
                }
            }
            else
            {
                return -1;
            }
        }
    }
}