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
            Console.WriteLine("Tổng: {0} + {1} = {2} ", a, b, *pa + *pb);
            Console.WriteLine("Nhấn phím bất kì kết thúc chương trình.");
            Console.ReadKey();
        }
    }
}
