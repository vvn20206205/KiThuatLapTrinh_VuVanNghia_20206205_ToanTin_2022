using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace bai2_2
{
    public class SinhVien
    {
        public string MaSoSinhVien;
        public string HoVaTen;
        public string HocPhan;
        public float Diem;
        public SinhVien Next;

        public SinhVien()
        {
            MaSoSinhVien = HoVaTen = HocPhan = string.Empty;
            Diem = 0;
            Next = null;
        }

    }
    class Program
    {
        // Hàm kiểm tra nhập thông tin sinh viên
        static Boolean NhapSV(SinhVien p)
        {
            Console.Write("Nhập mã sinh viên: ");
            p.MaSoSinhVien = Console.ReadLine();
            if (p.MaSoSinhVien != String.Empty)
            {
                Console.Write("Nhập họ tên: ");
                p.HoVaTen = Console.ReadLine();
                Console.Write("Nhập học phần: ");
                p.HocPhan = Console.ReadLine();
                Console.Write("Nhập điểm: ");
                p.Diem = Single.Parse(Console.ReadLine());
                return true;
            }
            return false;
        }
        // Hàm thêm thông tin sinh viên
        static void ThemSV(ref SinhVien L, SinhVien p)
        {
            if (L == null)
            {
                L = p;
            }
            else
            {
                SinhVien i = L;
                while (i.Next != null)
                {
                    i = i.Next;
                }
                i.Next = p;
                p.Next = null;
            }
        }
        // Hàm in 1 sinh viên
        static void Xuat1SV(SinhVien L)
        {
            Console.WriteLine("");
            Console.WriteLine("Mã số sinh viên: {0}", L.MaSoSinhVien);
            Console.WriteLine("Họ và tên: {0}", L.HoVaTen);
            Console.WriteLine("Học phần: {0}", L.HocPhan);
            Console.WriteLine("Điểm: {0}", L.Diem);
        }
        // Hàm in tất cả danh sách sinh viên
        static void XuatAllSV(SinhVien L)
        {
            SinhVien p = L;
            while (p != null)
            {
                Xuat1SV(p);
                p = p.Next;
            }
        }
        // Hàm tìm sinh viên theo mã số sinh viên
        static void TimSV(SinhVien L, string mssv)
        {
            SinhVien p = L; int dem = 0;
            while (p != null)
            {
                if (mssv == p.MaSoSinhVien)
                {
                    Console.WriteLine("\nThông tin sinh viên có MSSV là: {0}", mssv);
                    Xuat1SV(p); dem++;
                }
                p = p.Next;
            }
            if (dem == 0)
            {
                Console.WriteLine("Không tồn tại sinh viên có MSSV là: " + mssv);
            }
        }// Hàm xóa sinh viên theo mã số sinh viên
        static void XoaSV(SinhVien L, string mssv)
        {
            SinhVien p = L; int dem = 0;
            while (p != null)
            {
                if (p.Next != null && mssv == p.Next.MaSoSinhVien)
                {
                    dem++;
                    p.Next = p.Next.Next;
                    Console.WriteLine("Xóa sinh viên thành công!");
                    break;
                }
                else
                {
                    p = p.Next;
                }
            }
            if (dem == 0)
            {
                Console.WriteLine("Không tồn tại sinh viên có MSSV là: " + mssv);
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SinhVien L = null;
            int luachon;
            do
            {
                Console.WriteLine("Danh sách liên kết đơn Sinh viên.");
                Console.WriteLine("Vũ Văn Nghĩa MSSV: 20206205");
                Console.WriteLine("Lựa chọn:");
                Console.WriteLine("1. Thêm sinh viên.");
                Console.WriteLine("2. Tìm kiếm sinh viên.");
                Console.WriteLine("3. Xóa sinh viên.");
                Console.WriteLine("4. Hiển thị danh sách sinh viên.");
                Console.WriteLine("0. Thoát chương trình.");
                do
                {
                    bool kt = false;
                    do
                    {
                        Console.Write("Mời bạn nhập lựa chọn từ 0 đến 4: ");
                        string nNhap = Console.ReadLine();
                        kt = int.TryParse(nNhap, out luachon);
                    } while (!kt);
                } while (0 > luachon || luachon > 4);
                switch (luachon)
                {
                    case 1:
                        // Thêm sinh viên
                        SinhVien p = new SinhVien();
                        if (!NhapSV(p))
                        {
                            Console.WriteLine("Nhập sai! Thoát!");
                            break;
                        }
                        ThemSV(ref L, p);
                        Console.WriteLine("Thêm sinh viên thành công!");
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        // Tìm kiếm sinh viên
                        Console.Write("Nhập MSSV cần tìm: ");
                        string TimMSSV = Console.ReadLine();
                        TimSV(L, TimMSSV);
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        //    Xóa sinh viên
                        Console.Write("Nhập MSSV cần xóa: ");
                        string XoaMSSV = Console.ReadLine();
                        XoaSV(L, XoaMSSV);
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        //  Hiển thị danh sách sinh viên
                        Console.WriteLine("Danh sách sinh viên:");
                        XuatAllSV(L);
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (luachon != 0);
            // Thoát chương trình.
            Console.WriteLine("Bạn đã thoát chương trình!");
            Console.WriteLine("Nhấn phím bất kì kết thúc chương trình.");
            Console.ReadKey();
        }
    }
}
