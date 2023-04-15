//Vũ Văn Nghĩa_20206205
// Tìm kiếm bảng băm (OPTION)
//Bài 4.1.3 Bảng Băm
//Bài toán tìm số chữ cái xuất hiện trong dãy
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace KiThuatLapTrinh
{
    public static class Program
    {
        public static int hash_function(char c)
        {
            return (c - 'a');
        }
        public static void count_char(string S)
        {
            int[] indexC = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < S.Length; i++)
            {
                int index = hash_function(S[i]);
                indexC[index]++;
            }
            Console.WriteLine("Xét chuỗi {0}. Ta có:",S);
            Console.WriteLine("Số lần xuất hiện: ");
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine("Kí tự " + (char)(i + (int)'a') + ": " + indexC[i] + " lần");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            {
                string S = "ababcd"; count_char(S);
            }
            Console.WriteLine("Nhấn phím bất kì kết thúc chương trình.");
            Console.ReadKey();
        }
    }
}