//Vũ Văn Nghĩa_20206205
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace KiThuatLapTrinh
{
    public static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int i, j, k, m1, n1, m2, n2, sum = 0;

            int[,] arr1 = new int[50, 50];
            int[,] arr2 = new int[50, 50];
            int[,] ma_tran_tong = new int[50, 50];


            Console.Write("\nNhập số hàng và số cột của ma trận thứ nhất:\n");

            m1 = Convert.ToInt32(Console.ReadLine());

            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNhập số hàng và số cột của ma trận thứ hai:\n");

            m2 = Convert.ToInt32(Console.ReadLine());

            n2 = Convert.ToInt32(Console.ReadLine());

            if (m1 != m2 || n1 != n2)
            {
                Console.Write("Không thể cộng hai ma trận trên !!!");
                Console.Write("\nKích thước 2 ma trận phải giống nhau.");
            }
            else
            {
                Console.Write("Nhập các phần tử của ma trận thứ nhất:\n");
                for (i = 0; i < m1; i++)
                {
                    for (j = 0; j < n1; j++)
                    {

                        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.Write("Nhập các phần tử của ma trận thứ hai:\n");
                for (i = 0; i < m2; i++)
                {
                    for (j = 0; j < n2; j++)
                    {

                        arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.Write("\nIn ma trận thứ nhất:\n");
                for (i = 0; i < m1; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < n1; j++)
                        Console.Write("{0}\t", arr1[i, j]);
                }
                Console.Write("\nIn ma trận thứ hai:\n");
                for (i = 0; i < m2; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < n2; j++)
                        Console.Write("{0}\t", arr2[i, j]);
                }
                for (i = 0; i < m1; i++)
                {
                    for (j = 0; j < n2; j++)
                    {

                        ma_tran_tong[i, j] = arr1[i, j] + arr2[i, j];
                    }
                }
                Console.Write("\nMa trận tổng của hai ma trận trên là: \n");
                for (i = 0; i < m1; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < n2; j++)
                    {
                        Console.Write("{0}\t", ma_tran_tong[i, j]);
                    }
                }
                Console.Write("\n\n");
                Console.WriteLine("Nhấn phím bất kì kết thúc chương trình.");
                Console.ReadKey();
            }
        }
    }
}