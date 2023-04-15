using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20206205_Bai_8_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Sever SV = new Sever();
            int n; bool kt = false;
            do
            {
            Console.Write("Nhập số yêu cầu đến Sever (n > 0) : ");
                string nNhap = Console.ReadLine();
                kt = int.TryParse(nNhap, out n);
            } while (!kt||n<0);

            for (int i=0; i<n; i++)
            {
                SV.NhapSever();
            }
            // In kết quả
            Console.Clear();
            Console.Write("\nTổng số yêu cầu đến Sever: "+SV.TongYeuCau());

            Console.Write("\n------------Sever------------\n");

            for (int i = 0; i < n; i++)
            {
                SV.XuatSever();
            }
            Console.WriteLine("Nhấn phím bất kì kết thúc chương trình.");
            Console.ReadKey();
        }
    }
}
