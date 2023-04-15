//Vũ Văn Nghĩa_20206205
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace KiThuatLapTrinh
{
    class GFG
    {
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
        static void printArray(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine("Nhấn phím bất kì kết thúc chương trình.");
            Console.ReadKey();
        }
        public static void Main(String[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int n = arr.Length;
            quickSort(arr, 0, n - 1);
            printArray(arr, n);
        }
    }
}