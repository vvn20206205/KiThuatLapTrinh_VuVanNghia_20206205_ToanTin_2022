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
            Console.WriteLine("Bài toán tháp Hà Nội.");
            int n;
            bool kt = false;
            do
            {
                Console.Write("Nhập số nguyên dương n = ");
                string nNhap = Console.ReadLine();
                kt = int.TryParse(nNhap, out n);
            } while (!kt || n <= 0);

            char a = 'A', b = 'B', c = 'C';
            Console.WriteLine("Thứ tự chuyển là: ");
            Tower(n, a, b, c);
            Console.WriteLine("Nhấn phím bất kì kết thúc chương trình.");
            Console.ReadKey();
        }
        // Hàm đệ qui tìm cách chuyển
        public static void Tower(int n, char a, char b, char c)
        {
            if (n == 1)
            {
                Console.Write("\t{0} -----> {1}\n", a, c);
                return;
            }
            Tower(n - 1, a, c, b);
            Tower(1, a, b, c);
            Tower(n - 1, b, a, c);
        }
    }
}