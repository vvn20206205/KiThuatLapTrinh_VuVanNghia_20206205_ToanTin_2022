//Vũ Văn Nghĩa_20206205
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace KiThuatLapTrinh
{
    public static class Program
    {
        public unsafe static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int i = 0;
            string fullname = "Vu Van Nghia 20206205";
            fixed (char* ptr = fullname)
                while (true)
                {
                    if (*(ptr + i) == '\0')
                    {
                        break;
                    }
                    i++;
                }
            Console.WriteLine("Độ dài là: {0}", i);
            Console.WriteLine("Nhấn phím bất kì kết thúc chương trình.");
            Console.ReadKey();
        }
    }
}