//Vũ Văn Nghĩa_20206205
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MyForm
{
    //
    // Summary: Form đầu tiên của chương trình
    // Parameters:
    //     InPut: txtUser, txtPass
    // Returns: Khởi động FormMenuChinh
    // Exceptions:
    //
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!KiemTraDangNhap(txtUser.Text, txtPass.Text))
            {
                MessageBox.Show("Tài khoản mặc định: admin\nMật khẩu mặc định: 20206205\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Ẩn FormDangNhap mở FormMenuChinh
                this.Hide();
                FormMenuChinh frm = new FormMenuChinh();
                frm.Show();
            }
        }
        // Hàm kiểm tra nội dung đăng nhập
        // (kiểm tra tài khoản và mật khẩu)
        bool KiemTraDangNhap(string a, string b)
        {
            if (a != "admin")
            {
                return false;
            }
            if (b != "20206205")
            {
                return false;
            }
            return true;
        }
    }
}