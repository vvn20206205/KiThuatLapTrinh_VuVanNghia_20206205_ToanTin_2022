//Vũ Văn Nghĩa_20206205
using System;
// Mục đích của class này thể hiện tính kế thừa của Hướng đối tượng (OOP)
public class ConNguoi
{
    // 2 Thuộc tính của 1 con người là tên, ngày sinh
    private string hoTen;
    private DateTime ngaySinh;
    // Hàm khởi tạo 
    public ConNguoi()
    {
    }
    public string HoTen
    {
        get
        {
            return hoTen;
        }
        set
        {
            hoTen = value;
        }
    }
    public DateTime NgaySinh
    {
        get
        {
            return ngaySinh;
        }
        set
        {
            ngaySinh = value;
        }
    }
}