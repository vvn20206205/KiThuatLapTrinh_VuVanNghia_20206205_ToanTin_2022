//Vũ Văn Nghĩa_20206205
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MyForm
{
    //
    // Summary: form quan trọng nhất của chương trình
    // chứa  các chức năng thao tác quản lí danh sách sinh viên
    // Parameters:
    //     InPut: 
    // Returns: Các chức năng thao tác quản lí danh sách sinh viên
    // Exceptions:
    //
    public partial class FormMenuChinh : Form
    {
        // Em cài đặt Linked List (Danh sách liên kết) để quản lí Danh sách sinh viên
        // Kĩ thuật sử dụng con trỏ
        LinkedListQuanLiSinhVien QuanLiSinhVien = new LinkedListQuanLiSinhVien();
        // Hàm khởi tạo 
        public FormMenuChinh()
        {
            InitializeComponent();
            ResizeRedraw = false;
        }
        // Sự kiện Load FormMenuChinh
        private void FormMenuChinh_Load(object sender, EventArgs e)
        {
            // Ẩn 2 nút chức năng sửa, xóa khi mới bắt đầu
            buttonSuaSV.Enabled = false;
            buttonXoaSV.Enabled = false;
            // Khi bắt đầu form thì đặt giới hạn chọn ngày sinh sinh viên (chỉ chọn được năm sinh = năm hiện tại -18) vì sinh viên phải từ 18 tuổi trở lên.
            dateTimePicker1.MaxDate = new DateTime(DateTime.Now.Year - 18, 12, 12);
        }
        // Các chức năng của chương trình:

        //
        // Summary: 
        // Đọc file cơ sở dữ liệu ban đầu My_CSDL_KTLT.txt 
        // Parameters:
        //     InPut: Sự kiện ấn vào button này
        // Returns:
        // Danh sách sinh viên trong file cơ sở dữ liệu ban đầu My_CSDL_KTLT.txt
        // Exceptions:
        //
        private void DocCSDL_Click(object sender, EventArgs e)
        {
            QuanLiSinhVien.HamDocCSDL(dataGridViewDanhSachSinhVien, labelTongSoSinhVien);
        }
        //
        // Summary: 
        // Ghi danh sách hiện tại vào file cơ sở dữ liệu My_CSDL_KTLT.txt khi cần sao lưu
        // Parameters:
        //     InPut: Sự kiện ấn vào button này
        // Returns:
        // Danh sách sinh viên hiện tại vào file cơ sở dữ liệu My_CSDL_KTLT.txt 
        // Exceptions:
        //
        private void GhiCDL_Click(object sender, EventArgs e)
        {
            QuanLiSinhVien.HamGhiCSDL();
        }
        //
        // Summary: 
        // Đọc file .txt khi người dùng chọn DocFile
        // Parameters:
        //     InPut: Sự kiện ấn vào button này
        // Returns:
        
        // Exceptions:
        //
        private void buttonDocFile_Click(object sender, EventArgs e)
        {
            QuanLiSinhVien.DocFileSinhVien(dataGridViewDanhSachSinhVien, labelTongSoSinhVien);
        }
        //
        // Summary: 
        // Ghi danh sách hiện tại vào file .txt khi người dùng chọn GhiFile
        // Parameters:
        //     InPut: Sự kiện ấn vào button này
        // Returns:
        
        // Exceptions:
        //
        private void buttonGhiFile_Click(object sender, EventArgs e)
        {
            QuanLiSinhVien.GhiFileSinhVien();
        }
        //
        // Summary: 
        // Thêm sinh viên khi người dùng chọn ThemSV
        // Parameters:
        //     InPut: Sự kiện ấn vào button này
        // Returns:
        
        // Exceptions:
        //
        private void buttonThemSV_Click(object sender, EventArgs e)
        {
            QuanLiSinhVien.ButtonThemSinhVien(txtMSSV, txtHoTen, dateTimePicker1, txtKH, txtKV, txtLop, dataGridViewDanhSachSinhVien, labelTongSoSinhVien);
        }
        //
        // Summary: 
        // Lập trình hướng sự kiện event
        // Hàm hiển thị thông tin sinh viên khi chọn dòng thông tin sinh viên.
        // Parameters:
        //     InPut: 
        // (Sự kiện khi người dùng chọn dòng sinh viên trên DataGridView)
        // Returns:
        
        // Exceptions:
        //
                // Tạo sinh viên cũ để lưu giá trị thông tin cũ của sinh viên
        NodeSV LuuSinhVien;
        // Biến index là số dòng trên dataGridView
        int index;
        private void dataGridViewDanhSachSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0 && index < QuanLiSinhVien.Count())
            {
                // Tạo sinh viên cũ để lưu giá trị thông tin cũ của sinh viên
                LuuSinhVien = (QuanLiSinhVien.HienThiThongTinSVKHiChon(txtMSSV, txtHoTen, dateTimePicker1, txtKH, txtKV, txtLop, dataGridViewDanhSachSinhVien, LuuSinhVien, index, buttonSuaSV, buttonXoaSV));
            }
        }
        //
        // Summary: 
        // Sửa sinh viên khi người dùng chọn SuaSV
        // Parameters:
        //     InPut: Sự kiện ấn vào button này
        // Returns:
        
        // Exceptions:
        //
        private void buttonSuaSV_Click(object sender, EventArgs e)
        {
            QuanLiSinhVien.ButtonSuaSinhVien(txtMSSV, txtHoTen, dateTimePicker1, txtKH, txtKV, txtLop, dataGridViewDanhSachSinhVien, LuuSinhVien, index);
        }
        //
        // Summary: 
        // Xóa sinh viên khi người dùng chọn XoaSV
        // Parameters:
        //     InPut: Sự kiện ấn vào button này
        // Returns:
        
        // Exceptions:
        //
        private void buttonXoaSV_Click(object sender, EventArgs e)
        {
            QuanLiSinhVien.ButtonXoaSinhVien(txtMSSV, txtHoTen, dateTimePicker1, txtKH, txtKV, txtLop, dataGridViewDanhSachSinhVien, labelTongSoSinhVien, LuuSinhVien, index, buttonSuaSV, buttonXoaSV);
        }
        //
        // Summary: 
        // Tìm sinh viên khi người dùng chọn TimSV
        // Parameters:
        //     InPut: Sự kiện ấn vào button này
        // Returns:
        
        // Exceptions:
        //
        private void button4_Click(object sender, EventArgs e)
        {
            QuanLiSinhVien.ButtonTimSinhVien(txtMSSV, txtHoTen, dateTimePicker1, txtKH, txtKV, txtLop, dataGridViewDanhSachSinhVien, labelTongSoSinhVien, LuuSinhVien, index, buttonSuaSV, buttonXoaSV, radioButtonTTMSSV, radioButtonTTHoTen, radioButtonTTLop, txtNoiDungTimKiem);
        }
        //
        // Summary: 
        // Sắp xếp sinh viên khi người dùng chọn sắp xếp
        // Parameters:
        //     InPut: Sự kiện ấn vào button này
        // Returns:
        
        // Exceptions:
        //
        private void buttonAZ_Click(object sender, EventArgs e)
        {
            QuanLiSinhVien.ButtonSX_SinhVien(dataGridViewDanhSachSinhVien, buttonSuaSV, buttonXoaSV, radioButtonSXTMSSV, radioButtonSXTHoTen, radioButtonSXTLop, 1);
        }
        //
        // Summary: 
        // Sắp xếp sinh viên khi người dùng chọn sắp xếp
        // Parameters:
        //     InPut: Sự kiện ấn vào button này
        // Returns:
        
        // Exceptions:
        //
        private void buttonZA_Click(object sender, EventArgs e)
        {
            QuanLiSinhVien.ButtonSX_SinhVien(dataGridViewDanhSachSinhVien, buttonSuaSV, buttonXoaSV, radioButtonSXTMSSV, radioButtonSXTHoTen, radioButtonSXTLop, 2);
        }
        //
        // Summary: 
        // Thoát chương trình sinh viên khi người dùng chọn thoát chương trình
        // Parameters:
        //     InPut: Sự kiện ấn vào button này
        // Returns:
        // Thoát chương trình
        // Exceptions:
        //
        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn thoát chương trình?\n", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}