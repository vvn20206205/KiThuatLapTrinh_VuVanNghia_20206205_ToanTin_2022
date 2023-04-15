//Vũ Văn Nghĩa_20206205
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QLSV_CK_KTLT_MSSV_20206205
{
    //
    // Summary: Hàm chính của chương trình
    // Parameters:
    //     InPut:
    // Returns: Khởi động FormDangNhap
    // Exceptions:
    //
    internal static class Program
    {
        [STAThread]

        static void Main()
        {
            // Hàm main của chương trình bắt đầu FormDangNhap
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyForm.FormDangNhap());
        }
    }
}