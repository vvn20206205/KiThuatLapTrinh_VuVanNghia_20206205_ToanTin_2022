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
            float a = 2.5f;
            float* pa = &a;
            float b = 3.5f;
            float* pb = &b;
            Console.WriteLine("Ban đầu: \na = {0}\nb = {1}", *pa, *pb);
            float temp;
            temp = *pa;
            *pa = *pb;
            *pb = temp;
            Console.WriteLine("Tráo đổi: \na = {0}\nb = {1}", *pa, *pb);
            Console.WriteLine("Nhấn phím bất kì kết thúc chương trình.");
            Console.ReadKey();
        }
    }
}