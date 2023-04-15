//Vũ Văn Nghĩa_20206205
using System;
using System.Text;
namespace KiThuatLapTrinh
{
    public static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (char i = 'A'; i <= 'Z'; i++)
            { Console.WriteLine(i); }
            Console.WriteLine("Nhấn phím bất kì để tiếp tục!");
            Console.ReadKey();
        }
    }
}