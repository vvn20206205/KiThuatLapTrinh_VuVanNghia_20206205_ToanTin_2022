//Vũ Văn Nghĩa_20206205
using System;
using System.Windows.Forms;
// Mục đích của class này để tạo kí tự tiếng Việt
public class VietNamChar
{
    // Thuộc tính các chữ cái trong VietNamChar được đóng gói bởi phạm vi truy cập private 
    // Đây là thuộc tính tĩnh qua từ khóa static
    private static readonly char[] CharVietNam = new char[]
    {
'A','a','À','à','Á','á','Ả','ả','Ã','ã','Ạ','ạ',
'Ă','ă','Ằ','ằ','Ắ','ắ','Ẳ','ẳ','Ẵ','ẵ','Ặ','ặ',
'Â','â','Ầ','ầ','Ấ','ấ','Ẩ','ẩ','ẫ','Ẫ','Ậ','ậ',
'B','b',
'C','c',
'D','d',
'Đ','đ',
'E','e','È','è','É','é','Ẻ','ẻ','Ẽ','ẽ','Ẹ','ẹ',
'Ê','ê','Ề','ề','Ế','ế','Ể','ể','Ễ','ễ','Ệ','ệ',
'F','f',
'G','g',
'H','h',
'I','i','Ì','ì','Í','í','Ỉ','ỉ','Ĩ','ĩ','Ị','ị',
'K','k',
'L','l',
'M','m',
'N','n',
'O','o','Ò','ò','Ó','ó','Ỏ','ỏ','Õ','õ','Ọ','ọ',
'Ô','ô','Ồ','ồ','Ố','ố','Ổ','ổ','Ỗ','ỗ','Ộ','ộ',
'Ơ','ơ','Ờ','ờ','Ớ','ớ','Ở','ở','Ỡ','ỡ','Ợ','ợ',
'P','p',
'Q','q',
'R','r',
'S','s',
'T','t',
'U','u','Ù','ù','Ú','ú','Ủ','ủ','Ũ','ũ','Ụ','ụ',
'Ư','ư',
'V','v',
'X','x',
'Y','y',
'Z','z',
'W','w',' ',
    };
    // Hàm kiểm tra trong tên sinh viên có các kí tự khác CharVietNam không. Nếu có trả về false
    public static bool KiemTraHoTen(string str)
    {
        int dem = 0;
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 0; j < CharVietNam.Length; j++)
            {
                if ((str[i]) == CharVietNam[j])
                {
                    dem++;
                }
            }
        }
        for (int i = 0; i < str.Length - 1; i++)
        {
            if (Convert.ToString(str[i]) + Convert.ToString(str[i + 1]) == "  ")
            {
                MessageBox.Show("Lỗi tên chứa 2 khoảng trắng liền nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        if (dem == str.Length)
        {
            return true;
        }
        else
        {
            MessageBox.Show("Bạn đã nhập sai họ tên sinh viên.\nCó kí tự đặc biệt hoặc số trong tên.\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
    //   Hàm tách tên sinh viên lấy chữ cái đầu sử dụng Ngăn xếp MyLinkedListStack
    public static MyLinkedListStack HamXuLiMyLinkedListStackTen(string ten)
    {
        MyLinkedListStack MyStack = new MyLinkedListStack();
        MyStack.Push(ten[0]);
        for (int i = 0; i < ten.Length; i++)
        {
            if (ten[i] == ' ')
            {
                MyStack.Push(ten[i + 1]);
            }
        }
        return MyStack;
    }
    // Hàm tìm vị trí kí tự trong mảng kí tự
    public static int ViTriChar(char a)
    {
        for (int i = 0; i < CharVietNam.Length; i++)
        {
            if (a == CharVietNam[i])
            {
                return i;
            }
        }
        return 0;
    }
    // Hàm so sánh 2 kí tự trong CharVietNam
    public static int SoSanhChar(char a, char b)
    {
        return ViTriChar(a) - ViTriChar(b);
    }
    // Hàm so sánh 2 tên sinh viên để sắp xếp
    public static int SoSanhHoTen(string a, string b)
    {
        MyLinkedListStack MyStack1 = HamXuLiMyLinkedListStackTen(a);
        MyLinkedListStack MyStack2 = HamXuLiMyLinkedListStackTen(b);
        char ten1 = MyStack1.Pop();
        char ten2 = MyStack2.Pop();
        while (a == b)
        {
            try
            {
                ten1 = MyStack1.Pop();
                ten2 = MyStack2.Pop();
            }
            catch
            {
                break;
            }
        }
        if (SoSanhChar(ten1, ten2) > 0)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }
}
