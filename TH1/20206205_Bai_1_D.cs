//Vũ Văn Nghĩa_20206205
using System;
namespace KiThuatLapTrinh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n; bool kt = false;
            do
            {
                Console.Write("Nhập chiều cao của cây thông: ");
                string nNhap = Console.ReadLine();
                kt = int.TryParse(nNhap, out n);
            } while (!kt);
            // Vẽ phần trên
            for (int i = 1; i <= n - 1; i++)
            {
                for (int j = 1; j < 2 * n; j++)
                {
                    if (Math.Abs(n - j) <= (i - 1))
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.Write("\n");
            }
            //Vẽ gốc cây
            for (int j = 1; j < 2 * n; j++)
            {
                if (j == n)
                {
                    Console.Write(" * ");
                }
                else
                {
                    Console.Write("   ");
                }
            }
            Console.ReadKey();
        }
    }
}