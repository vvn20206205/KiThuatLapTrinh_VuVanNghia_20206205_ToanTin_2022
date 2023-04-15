//Vũ Văn Nghĩa_20206205
using System;
namespace KiThuatLapTrinh
{
    public class SoPhuc
    {
        // Em mới tìm hiểu class
        // Em nghĩ Hệ số thực,hệ số ảo nhập từ bàn phím lên không cần để private
        public double HeSoThuc;
        public double HeSoAo;
        public void InSoPhuc()
        {
            if (Math.Abs(HeSoAo) < 0.00000000001) { HeSoAo = 0; }
            if (Math.Abs(HeSoThuc) < 0.00000000001) { HeSoThuc = 0; }
            if (HeSoAo < 0)
            {
                double HeSoAoAm = -HeSoAo;
                Console.Write(Math.Round(HeSoThuc, 10) + "-" + Math.Round(HeSoAoAm, 10) + "i");
            }
            else
            {
                Console.Write(Math.Round(HeSoThuc, 10) + "+" + Math.Round(HeSoAo, 10) + "i");
            }
        }
        public void NhapSoPhuc()
        {
            // Ta có dạng số ảo HeSoThuc+HeSoAo*i
            string BieuThuc; int ViTriDauCong, ViTriDauTru, ViTriPhanAoI;
            // Cắt các khoảng trắng dư ở đầu và cuối chuỗi khi nhap
            BieuThuc = Console.ReadLine();
            BieuThuc = BieuThuc.Trim();
            HeSoAo = 10;
            // BieuThuc = "5+6i";
            ViTriDauCong = BieuThuc.LastIndexOf("+");
            ViTriDauTru = BieuThuc.LastIndexOf("-");
            ViTriPhanAoI = BieuThuc.LastIndexOf("i");
            if (ViTriPhanAoI < 0)
            {
                HeSoThuc = Convert.ToSingle(BieuThuc.Substring(0));
                HeSoAo = 0;
            }
            else
            {
                if (ViTriDauCong > 0)
                {
                    HeSoThuc = Convert.ToSingle(BieuThuc.Substring(0, ViTriDauCong));
                    HeSoAo = Convert.ToSingle(BieuThuc.Substring(ViTriDauCong, ViTriPhanAoI - ViTriDauCong));
                }
                else
                {
                    if (ViTriDauTru > 0)
                    {
                        HeSoThuc = Convert.ToSingle(BieuThuc.Substring(0, ViTriDauTru));
                        HeSoAo = Convert.ToSingle(BieuThuc.Substring(ViTriDauTru, ViTriPhanAoI - ViTriDauTru));
                    }
                    else
                    {
                        HeSoThuc = 0;
                        HeSoAo = Convert.ToSingle(BieuThuc.Substring(0, ViTriPhanAoI));
                    }
                }

            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Phương trình bậc hai có dạng ax^2 + bx +c = 0
            // Nhập hệ số a,b,c
            SoPhuc a = new SoPhuc();
            Console.Write("\nMời bạn nhập hệ số a: ");
            a.NhapSoPhuc(); Console.Write("Hệ số a: ");
            a.InSoPhuc();
            SoPhuc b = new SoPhuc();
            Console.Write("\nMời bạn nhập hệ số b: ");
            b.NhapSoPhuc(); Console.Write("Hệ số b: ");
            b.InSoPhuc();
            SoPhuc c = new SoPhuc();
            Console.Write("\nMời bạn nhập hệ số c: ");
            c.NhapSoPhuc(); Console.Write("Hệ số c: ");
            c.InSoPhuc();

            // In phương trình đã nhập ra màn hình
            Console.WriteLine("\nPhương trình bậc hai cần giải là:");
            Console.Write("("); a.InSoPhuc(); Console.Write(")"); Console.Write("x^2 + ");
            Console.Write("("); b.InSoPhuc(); Console.Write(")"); Console.Write("x + ");
            Console.Write("("); c.InSoPhuc(); Console.Write(") = 0\n");

            HamGiaiPT(a, b, c);
            Console.ReadKey();
        }

        //Giải phương trình bậc 2
        public static void HamGiaiPT(SoPhuc a, SoPhuc b, SoPhuc c)
        {
            //Tạo số phức 4 của delta =b^2-4ac
            //Tạo số phức 0 và 2
            SoPhuc Bon = new SoPhuc();
            Bon.HeSoThuc = 4;
            Bon.HeSoAo = 0;
            SoPhuc Khong = new SoPhuc();
            Khong.HeSoThuc = 0;
            Khong.HeSoAo = 0;
            SoPhuc Hai = new SoPhuc();
            Hai.HeSoThuc = 2;
            Hai.HeSoAo = 0;
            //Tính delta
            SoPhuc delta = new SoPhuc();
            delta = Hieu(Tich(b, b), Tich(Bon, Tich(a, c)));
            if (delta.HeSoThuc == 0 && delta.HeSoAo == 0)
            {
                SoPhuc NghiemSo0 = new SoPhuc();
                NghiemSo0 = Thuong(Hieu(Khong, b), Tich(Hai, a));
                Console.Write("Nghiệm của phương trình đã cho là: "); NghiemSo0.InSoPhuc();
                Console.Write(" ( nghiệm kép )");
            }
            else
            {//Tính căn delta
                SoPhuc CanDeltaMot = new SoPhuc(); SoPhuc CanDeltaHai = new SoPhuc();
                CanDeltaMot = TinhCanMot(delta);
                CanDeltaHai = Hieu(Khong, CanDeltaMot);
                //Tính nghiệm
                SoPhuc NghiemSo1 = new SoPhuc();
                SoPhuc NghiemSo2 = new SoPhuc();
                NghiemSo1 = Thuong(Tong(Hieu(Khong, b), CanDeltaMot), Tich(Hai, a));
                NghiemSo2 = Thuong(Tong(Hieu(Khong, b), CanDeltaHai), Tich(Hai, a));
                Console.Write("Nghiệm của phương trình đã cho là: "); NghiemSo1.InSoPhuc();
                Console.Write("\nNghiệm của phương trình đã cho là: "); NghiemSo2.InSoPhuc();
            }
        }
        //Hàm tính +,-,x,/,căn
        public static SoPhuc Tong(SoPhuc a, SoPhuc b)
        {
            SoPhuc Tong = new SoPhuc();
            Tong.HeSoThuc = a.HeSoThuc + b.HeSoThuc;
            Tong.HeSoAo = a.HeSoAo + b.HeSoAo;
            return Tong;
        }
        public static SoPhuc Hieu(SoPhuc a, SoPhuc b)
        {
            SoPhuc Hieu = new SoPhuc();
            Hieu.HeSoThuc = a.HeSoThuc - b.HeSoThuc;
            Hieu.HeSoAo = a.HeSoAo - b.HeSoAo;
            return Hieu;
        }
        public static SoPhuc Tich(SoPhuc a, SoPhuc b)
        {
            SoPhuc Tich = new SoPhuc();
            Tich.HeSoThuc = a.HeSoThuc * b.HeSoThuc - a.HeSoAo * b.HeSoAo;
            Tich.HeSoAo = a.HeSoThuc * b.HeSoAo + a.HeSoAo * b.HeSoThuc;
            return Tich;
        }
        public static SoPhuc Thuong(SoPhuc a, SoPhuc b)
        {
            SoPhuc Thuong = new SoPhuc();
            Thuong.HeSoThuc = (a.HeSoThuc * b.HeSoThuc + a.HeSoAo * b.HeSoAo) / (b.HeSoThuc * b.HeSoThuc + b.HeSoAo * b.HeSoAo);
            Thuong.HeSoAo = (a.HeSoAo * b.HeSoThuc - a.HeSoThuc * b.HeSoAo) / (b.HeSoThuc * b.HeSoThuc + b.HeSoAo * b.HeSoAo);
            return Thuong;
        }
        public static SoPhuc TinhCanMot(SoPhuc a)
        {
            SoPhuc TinhCanMot = new SoPhuc();
            double RSoPhucLT = Math.Sqrt(a.HeSoThuc * a.HeSoThuc + a.HeSoAo * a.HeSoAo);
            double GocArcCos = 0, GocArcSin = 0;
            if (a.HeSoThuc >= 0 && a.HeSoAo >= 0) { GocArcCos = Math.Acos(a.HeSoThuc / RSoPhucLT); GocArcSin = Math.Asin(a.HeSoAo / RSoPhucLT); }
            if (a.HeSoThuc <= 0 && a.HeSoAo >= 0) { GocArcCos = Math.Acos(a.HeSoThuc / RSoPhucLT); GocArcSin = Math.PI - Math.Asin(a.HeSoAo / RSoPhucLT); }
            if (a.HeSoThuc <= 0 && a.HeSoAo <= 0) { GocArcCos = -Math.Acos(a.HeSoThuc / RSoPhucLT); GocArcSin = -Math.PI - Math.Asin(a.HeSoAo / RSoPhucLT); }
            if (a.HeSoThuc >= 0 && a.HeSoAo <= 0) { GocArcCos = -Math.Acos(a.HeSoThuc / RSoPhucLT); GocArcSin = Math.Asin(a.HeSoAo / RSoPhucLT); }
            TinhCanMot.HeSoThuc = Math.Sqrt(RSoPhucLT) * Math.Cos(GocArcCos / 2);
            TinhCanMot.HeSoAo = Math.Sqrt(RSoPhucLT) * Math.Sin(GocArcSin / 2);
            return TinhCanMot;
        }
    }
}