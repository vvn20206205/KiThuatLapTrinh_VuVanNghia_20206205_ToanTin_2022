//Vũ Văn Nghĩa_20206205
using System;
// Một Node con của danh sách liên kết Danh sách sinh viên
public class NodeSV
{
    public SinhVien SV;
    public NodeSV prev, next;
    // Hàm khởi tạo 
    public NodeSV(SinhVien SV, NodeSV prev, NodeSV next)
    {
        this.SV = SV;
        this.prev = prev;
        this.next = next;
    }
    // Hàm trả về chuỗi của đối tượng trong class
    public string ToString()
    {
        return SV.ToString();
    }
}