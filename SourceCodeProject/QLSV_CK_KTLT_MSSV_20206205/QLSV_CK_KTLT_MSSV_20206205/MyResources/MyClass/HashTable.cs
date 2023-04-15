//Vũ Văn Nghĩa_20206205
// Em định sử dụng kĩ thuật hash (Băm) nhưng em thấy khá phức tạp.
using System;
using System.Windows.Forms;
// Kĩ thuật băm
public class HashTable
{
    // Kí tự cuối bảng VietNamChar có vị trí là 164
    // Độ dài của string lớp học khoảng 30
    // => M khoảng 76260
    // Chọn M =76261 ( số nguyên tố )
    private static int M = 76261;
    private int[] MangBam = new int[M];
    // Hàm băm 
    public static int HashFunction(string word)
    {
        int h = 0;
        /* if (word != "")
        {
        for (int i = word.Length-10; i < word.Length; i++)
        {
        if (0 <= (int)(word[i]) && (int)(word[i]) < 10)
        {
        h += (int)(word[i]);
        continue;
        }
        h += (VietNamChar.ViTriChar(word[i]) * 1566083941 * (i + 1));
        h += (VietNamChar.ViTriChar(word[i]) *123456789);
        }
        }*/
        h = word.GetHashCode();
        // GetHashCode(); là hàm băm có sẵn của ngôn ngữ C#
        return h;
    }
    public static void SapXepHash(LinkedListQuanLiSinhVien DS)
    {
        string NoiDung = "";
        NodeSV current = DS.Head;
        while (current != null)
        {
            NoiDung += "\n" + Convert.ToString((HashFunction(current.SV.Lop)));
            current = current.next;
        }
        MessageBox.Show(NoiDung, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}