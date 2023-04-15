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
            XoaCacPhanTuTrungNhau(Mang);
            Console.WriteLine("\nNhấn phím bất kì kết thúc chương trình.");
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
            //Hàm xóa các phần tử trùng nhau trong một mảng
            static void XoaCacPhanTuTrungNhau(int[] Mang)
            {
                int n = Mang.Length;
                // Array.Sort(Mang);
                quickSort(Mang, 0, n - 1);
                Console.WriteLine("Mảng sau khi xóa các phần tử trùng nhau là:");


                if (Mang[0] != Mang[1])
                    Console.Write(Mang[0] + " ");
                for (int i = 1; i < n - 1; i++)
                    if (Mang[i] != Mang[i + 1] && Mang[i] != Mang[i - 1])
                        Console.Write(Mang[i] + " ");
                if (Mang[n - 2] != Mang[n - 1])
                    Console.Write(Mang[n - 1] + " ");
            }
            Hàm Quick Sort để sắp xếp phần tử
            static void swap(int[] arr, int i, int j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
            static int partition(int[] arr, int low, int high)
            {
                int pivot = arr[high];
                int i = (low - 1);
                for (int j = low; j <= high - 1; j++)
                {
                    if (arr[j] < pivot)
                    {
                        i++;
                        swap(arr, i, j);
                    }
                }
                swap(arr, i + 1, high);
                return (i + 1);
            }
            static void quickSort(int[] arr, int low, int high)
            {
                if (low < high)
                {
                    int pi = partition(arr, low, high);
                    quickSort(arr, low, pi - 1);
                    quickSort(arr, pi + 1, high);
                }
            }
        }
    }
}


