//Vũ Văn Nghĩa_20206205
using System;
using System.IO;
using System.Text;
namespace KiThuatLapTrinh
{
    public class MyDanhSach
    {
        public string GiaTri;
        public MyDanhSach Next;

        public MyDanhSach()
        {
            GiaTri = null;
            Next = null;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            MyDanhSach L = null;
            int luachon;
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Vũ Văn Nghĩa MSSV: 20206205");
                Console.WriteLine("Cấu trúc dữ liệu danh sách:");
                Console.WriteLine("1. Thêm một phần tử trong danh sách.");
                Console.WriteLine("2. Sửa một phần tử trong danh sách.");
                Console.WriteLine("3. Xóa một phần tử trong danh sách.");
                Console.WriteLine("4. Tìm kiếm một phần tử trong danh sách.");
                Console.WriteLine("5. Hiển thị danh sách hiện tại.");
                Console.WriteLine("0. Thoát chương trình.");
                do
                {
                    bool kt = false;
                    do
                    {
                        Console.Write("Mời bạn nhập lựa chọn từ 0 đến 5: ");
                        string nNhap = Console.ReadLine();
                        kt = int.TryParse(nNhap, out luachon);
                    } while (!kt);
                } while (0 > luachon || luachon > 5);
                switch (luachon)
                {
                    case 1:
                        // Thêm một phần tử trong danh sách.
                        MyDanhSach Them = new MyDanhSach();
                        Console.Write("Nhập giá trị của phần tử: ");
                        Them.GiaTri = Console.ReadLine();
                        ThemPT(ref L, Them);
                        Console.WriteLine("Thêm một phần tử trong danh sách thành công!");
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        // Sửa một phần tử trong danh sách.
                        MyDanhSach Sua = new MyDanhSach();
                        Console.Write("Nhập giá trị của phần tử cần sửa: ");
                        string GiaTriCu = Console.ReadLine();
                        Console.Write("Nhập giá trị mới của phần tử cần sửa: ");
                        string GiaTriMoi = Console.ReadLine();
                        SuaPT(L, GiaTriCu, GiaTriMoi);
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        // Xóa một phần tử trong danh sách.
                        Console.Write("Nhập giá trị của phần tử cần xóa: ");
                        string Xoa = Console.ReadLine();
                        XoaPT(L, Xoa);
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        // Tìm kiếm một phần tử trong danh sách.
                        Console.Write("Nhập giá trị của phần tử cần tìm: ");
                        string Tim = Console.ReadLine();
                        TimPT(L, Tim);

                        Console.WriteLine("Nhấn phím bất kì để tiếp tục!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        // Hiển thị danh sách hiện tại.
                        Console.WriteLine("Danh sách hiện tại là:");
                        XuatDanhSach(L);
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (luachon != 0);
            Console.WriteLine("Bạn đã thoát chương trình!");
            Console.WriteLine("Nhấn phím bất kì kết thúc chương trình.");
            Console.ReadKey();
        }
        // Hàm xuất danh sách
        static void XuatDanhSach(MyDanhSach L)
        {
            MyDanhSach p = L;
            while (p != null)
            {
                Console.Write("{0}\t", p.GiaTri);
                p = p.Next;
            }
            Console.Write("\n");
        }
        // Hàm Thêm một phần tử trong danh sách.
        static void ThemPT(ref MyDanhSach L, MyDanhSach p)
        {
            if (L == null)
            {
                L = p;
            }
            else
            {
                MyDanhSach i = L;
                while (i.Next != null)
                {
                    i = i.Next;
                }
                i.Next = p;
                p.Next = null;
            }
        }
        // Hàm Sửa một phần tử trong danh sách.
        static void SuaPT(MyDanhSach L, string gtc, string gtm)
        {
            MyDanhSach p = L; int dem = 0;
            while (p != null)
            {
                if (p.Next != null && gtc == p.GiaTri)
                {
                    dem++;
                    p.GiaTri = gtm;
                    Console.WriteLine("Sửa một phần tử trong danh sách thành công!");
                    break;
                }
                else
                {
                    p = p.Next;
                }
            }
            if (dem == 0)
            {
                Console.WriteLine("Không tồn tại phần tử có giá trị là: " + gtc);
            }
        }
        // Hàm Xóa một phần tử trong danh sách.
        static void XoaPT(MyDanhSach L, string gt)
        {
            MyDanhSach p = L; int dem = 0;
            while (p != null)
            {
                if (p.Next != null && gt == p.Next.GiaTri)
                {
                    dem++;
                    p.Next = p.Next.Next;
                    Console.WriteLine("Xóa một phần tử có giá trị là:{0} trong danh sách thành công!", gt);
                    break;
                }
                else
                {
                    p = p.Next;
                }
            }
            if (dem == 0)
            {
                Console.WriteLine("Không tồn tại phần tử có giá trị là: " + gt);
            }
        }// Hàm tìm một phần tử trong danh sách.
        static void TimPT(MyDanhSach L, string t)
        {
            MyDanhSach p = L; int dem = 0;
            while (p != null)
            {
                if (t == p.GiaTri)
                {
                    Console.WriteLine("Có tồn tại phần tử có giá trị là: {0} trong danh sách",t);
                  dem++;
                }
                p = p.Next;
            }
            if (dem == 0)
            {
                Console.WriteLine("Không tồn tại phần tử có giá trị là: {0} trong danh sách",t);
            }
        }
    }
}