//Vũ Văn Nghĩa_20206205
using System;
public class SinhVien : ConNguoi
{
    // Các thuộc tính của đối tượng được đóng gói bởi phạm vi truy cập private
    private int maSoSinhVien;
    private string khoaHoc;
    private string khoaVien;
    private string lop;
    // Hàm khởi tạo 
    public SinhVien()
    {
    }
    // Hàm khởi tạo 1 đối tượng
    public SinhVien(int mssv, string ht, DateTime ns, string kh, string kv, string l)
    {
        MaSoSinhVien = mssv;
        HoTen = ht;
        NgaySinh = ns;
        KhoaHoc = kh;
        KhoaVien = kv;
        Lop = l;
    }
    // Phương thức truy vấn, phương thức cập nhật thuộc tính  của  SinhVien
    public int MaSoSinhVien
    {
        get
        {
            return this.maSoSinhVien;
        }
        set
        {
            this.maSoSinhVien = value;
        }
    }
    public string KhoaHoc
    {
        get
        {
            return this.khoaHoc;
        }
        set
        {
            this.khoaHoc = value;
        }
    }
    public string KhoaVien
    {
        get
        {
            return this.khoaVien;
        }
        set
        {
            this.khoaVien = value;
        }
    }
    public string Lop
    {
        get
        {
            return this.lop;
        }
        set
        {
            this.lop = value;
        }
    }
    // Hàm trả về chuỗi của đối tượng trong class
    public string ToString()
    {
        // Định dạng ngày sinh theo dd/MM/yyyy (theo văn hóa Việt Nam)
        return MaSoSinhVien + ";" + HoTen + ";" + Convert.ToDateTime(NgaySinh).Month.ToString() + "/" + Convert.ToDateTime(NgaySinh).Day.ToString() + "/" + Convert.ToDateTime(NgaySinh).Year.ToString() + ";" + khoaHoc + ";" + khoaVien + ";" + Lop;
    }
}