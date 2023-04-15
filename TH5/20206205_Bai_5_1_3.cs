//Vũ Văn Nghĩa_20206205
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace KiThuatLapTrinh
{
    class GFG
    {
        static void bubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            bubbleSort(arr);
            Console.WriteLine("Sorted array");
            printArray(arr);

            Console.WriteLine("Nhấn phím bất kì kết thúc chương trình.");
            Console.ReadKey();
        }
    }
}