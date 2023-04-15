//Vũ Văn Nghĩa_20206205
// Em cài đặt Linked List (Danh sách liên kết) để quản lí Danh sách sinh viên
// Kĩ thuật sử dụng con trỏ
using System;
using System.IO;
using System.Windows.Forms;
// Class chứa các chức năng của chương trình
public class LinkedListQuanLiSinhVien
{
    // Các thuộc tính của Linked List được đóng gói bởi phạm vi truy cập private
    private int size;
    private NodeSV headSV;
    private NodeSV tailSV;
    // Hàm khởi tạo 
    public LinkedListQuanLiSinhVien()
    {
        this.size = 0;
        this.headSV = null;
        this.tailSV = null;
    }
    // Phương thức truy vấn, phương thức cập nhật thuộc tính headSV của Linked List
    public NodeSV Head
    {
        get
        {
            return this.headSV;
        }
        set
        {
            this.headSV = value;
        }
    }
    // Hàm xóa tất cả danh sách sinh viên
    public void Clear()
    {
        NodeSV currentSV = this.headSV;
        while (currentSV != null)
        {
            NodeSV tempNodeSV = currentSV.next;
            currentSV.SV = null;
            currentSV.prev = null;
            currentSV.next = null;
            currentSV = tempNodeSV;
        }
        headSV = tailSV = null;
        this.size = 0;
    }
    // Hàm tính tổng tất cả sinh viên danh sách sinh viên
    public int Count()
    {
        return this.size;
    }
    // Hàm kiểm tra danh sách sinh viên có rỗng không
    public Boolean isEmpty()
    {
        return this.size == 0;
    }
    // Thêm 1 sinh viên vào đầu danh sách
    public void ThemSVDau(SinhVien element)
    {
        if (isEmpty())
        {
            headSV = tailSV = new NodeSV(element, prev: null, next: null);
        }
        else
        {
            tailSV.next = new NodeSV(element, tailSV, next: null);
            tailSV = tailSV.next;
        }
        this.size++;
    } // Thêm 1 sinh viên vào cuối danh sách
    public void ThemSVCuoi(SinhVien element)
    {
        if (isEmpty())
        {
            headSV = tailSV = new NodeSV(element, prev: null, next: null);
        }
        else
        {
            tailSV.next = new NodeSV(element, tailSV, next: null);
            tailSV = tailSV.next;
        }
        this.size++;
    }
    // Xóa sinh viên đầu danh sách
    public SinhVien XoaSVDau()
    {
        if (isEmpty())
        {
            MessageBox.Show("Danh sách sinh viên hiện tại đang rỗng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
        else
        {
            SinhVien data = headSV.SV;
            headSV = headSV.next;
            this.size--;
            if (isEmpty())
            {
                tailSV = null;
            }
            else
            {
                headSV.prev = null;
            }
            return data;
        }
    }
    // Xóa sinh viên cuối danh sách
    public SinhVien XoaSVCuoi()
    {
        if (isEmpty())
        {
            MessageBox.Show("Danh sách sinh viên hiện tại đang rỗng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
        else
        {
            SinhVien element = tailSV.SV;
            tailSV = tailSV.prev;
            this.size--;
            if (isEmpty())
            {
                headSV = null;
            }
            else
            {
                tailSV.next = null;
            }
            return element;
        }
    }
    // Xóa sinh viên bất kì trong danh sách
    public SinhVien XoaSV(NodeSV node)
    {
        if (node.prev == null)
        {
            XoaSVDau();
            return null;
        }
        if (node.next == null)
        {
            XoaSVCuoi();
            return null;
        }
        node.prev.next = node.next;
        node.next.prev = node.prev;
        SinhVien element = node.SV;
        this.size--;
        node.SV = null;
        node.prev = null;
        node.next = null;
        node = null;
        return element;
    }
    // Xóa sinh viên theo vị trí trong danh sách
    public SinhVien XoaSVTheoVT(int index)
    {
        int i;
        NodeSV currentNode;
        if (index < this.size / 2)
        {
            i = 0;
            currentNode = headSV;
            while (i != index)
            {
                currentNode = currentNode.next;
                i++;
            }
        }
        else
        {
            i = this.size - 1;
            currentNode = tailSV;
            while (i != index)
            {
                currentNode = currentNode.prev;
                i--;
            }
        }
        return XoaSV(currentNode);
    }
    // Hàm Đọc file cơ sở dữ liệu ban đầu My_CSDL_KTLT.txt 
    public void HamDocCSDL(DataGridView dataGridViewDSSV, Label labelTongSoSinhVien)
    {
        // Đặt lại 
        dataGridViewDSSV.Rows.Clear();
        this.size = 0;
        this.headSV = null;
        this.tailSV = null;
        try
        {
            using (StreamReader reader = new StreamReader("..\\..\\MyResources\\MyDatabase\\My_CSDL_KTLT.txt"))
            {
                string line;
                // Đọc từng dòng cho đến hết file
                while ((line = reader.ReadLine()) != null)
                {
                    string[] svien = line.Split(';');
                    // Em sử dụng dataGridView để hiển thị danh sách sinh viên
                    // Thêm thông tin sinh viên vào dataGridView
                    dataGridViewDSSV.Rows.Add(svien);
                    // Tạo sinh viên mới và thêm vào danh sách sinh viên
                    int mssv = Convert.ToInt32(svien[0]);
                    string ht = svien[1];
                    DateTime ns = Convert.ToDateTime(svien[2]);
                    string kh = svien[3];
                    string kv = svien[4];
                    string l = svien[5];
                    SinhVien newSinhVien = new SinhVien(mssv, ht, ns, kh, kv, l);
                    ThemSVCuoi(newSinhVien);
                }
                reader.Close();
                // Thay đổi tổng số lượng sinh viên trên Label
                labelTongSoSinhVien.Text = "Tổng số sinh viện trong danh sách hiện tại: " + Convert.ToString(this.size);
                MessageBox.Show("Đọc file cơ sở dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception)
        {
            // Nếu có lỗi xảy ra thì bỏ qua và dữ liệu ban đầu chưa có;
        }
    }
    // Hàm ghi danh sách hiện tại vào file cơ sở dữ liệu My_CSDL_KTLT.txt khi cần sao lưu
    public void HamGhiCSDL()
    {
        if (isEmpty())
        {
            MessageBox.Show("Danh sách sinh viên hiện tại đang rỗng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            string NoiDung = "";
            NodeSV currentSV = this.headSV;
            // Đọc từng dòng cho đến hết file và ghi thông tin sinh viên vào biến nội dung
            while (currentSV != null)
            {
                NoiDung += currentSV.ToString() + "\n";
                currentSV = currentSV.next;
            }
            MessageBox.Show(NoiDung, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            try
            {
                using (StreamWriter writer = new StreamWriter("..\\..\\MyResources\\MyDatabase\\My_CSDL_KTLT.txt"))
                {
                    writer.Write(NoiDung);
                    writer.Close();
                    MessageBox.Show("Ghi danh sách sinh viên ra file CSDL thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                //   Nếu có lỗi thì hiện ra thông báo
                MessageBox.Show("Đã có lỗi xảy ra\nVui lòng kiểm tra lại???", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    // Hàm đọc file khi người dùng chọn đọc file
    public void DocFileSinhVien(DataGridView dataGridViewDSSV, Label labelTongSoSinhVien)
    {
        // Mở cửa sổ chọn file txt
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filePath = openFileDialog.FileName;
            var fileStream = openFileDialog.OpenFile();
            try
            {
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    string line;
                    // Đọc từng dòng cho đến hết file
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] svien = line.Split(';');
                        int mssv = Convert.ToInt32(svien[0]);
                        // Kiểm tra xem mã số sinh viên có bị trùng không
                        if (!KiemTraTrungMaSoSinhVien(mssv))
                        {
                            MessageBox.Show("Lưu ý: Mã số sinh viên phải là duy nhất không được trùng.\nMã số sinh viên: " + mssv + " đã tồn tại trong danh sách.\nVui lòng kiểm tra lại file đầu vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // Tạo sinh viên mới và thêm vào danh sách sinh viên
                            string ht = svien[1];
                            DateTime ns = Convert.ToDateTime(svien[2]);
                            string kh = svien[3];
                            string kv = svien[4];
                            string l = svien[5];
                            SinhVien newSinhVien = new SinhVien(mssv, ht, ns, kh, kv, l);
                            ThemSVCuoi(newSinhVien);
                            // Thêm thông tin sinh viên vào dataGridView
                            dataGridViewDSSV.Rows.Add(svien);
                        }
                    }
                    reader.Close();
                }
            }
            catch (Exception)
            {
                // Nếu có lỗi thì hiện ra thông báo
                MessageBox.Show("Đã có lỗi xảy ra\nVui lòng kiểm tra lại file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Thay đổi tổng số lượng sinh viên trên Label
        labelTongSoSinhVien.Text = "Tổng số sinh viện trong danh sách hiện tại: " + Convert.ToString(this.size);
    }
    // Hàm kiểm tra mã số sinh viên có bị trùng trong danh sách hay không
    public bool KiemTraTrungMaSoSinhVien(int mssv)
    {
        if (isEmpty())
        {
            return true;
        }
        else
        {
            NodeSV currentSV = this.headSV;
            while (currentSV != null)
            {
                if (currentSV.SV.MaSoSinhVien == mssv)
                {
                    return false;
                }
                currentSV = currentSV.next;
            }
            return true;
        }
    }
    // Hàm ghi danh sách sinh viên ra file.
    public void GhiFileSinhVien()
    {
        if (isEmpty())
        {
            MessageBox.Show("Danh sách sinh viên hiện tại đang rỗng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            string NoiDung = "";
            NodeSV currentSV = this.headSV;
            // Đọc từng dòng cho đến hết file và ghi thông tin sinh viên vào biến nội dung
            while (currentSV != null)
            {
                NoiDung += currentSV.ToString() + "\n";
                currentSV = currentSV.next;
            }
            // Mở cửa sổ chọn file txt
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                var fileStream = saveFileDialog.OpenFile();
                try
                {
                    using (StreamWriter writer = new StreamWriter(fileStream))
                    {
                        writer.Write(NoiDung);
                        writer.Close();
                        MessageBox.Show("Ghi danh sách sinh viên ra file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    //   Nếu có lỗi thì hiện ra thông báo
                    MessageBox.Show("Đã có lỗi xảy ra\nVui lòng kiểm tra lại file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    // Hàm kiểm tra người dùng không nhập nội dung vào các TextBox
    public static bool KiemTraNoiDungTextBox(TextBox a)
    {
        if (string.IsNullOrWhiteSpace(a.Text))
        {
            MessageBox.Show("Bạn chưa nhập đủ nội dung.\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            a.Focus();
            return false;
        }
        return true;
    }
    // Hàm kiểm tra người dùng nhập mã số sinh viên là số nguyên có 8 chữ số VD: 20206205
    // 19560000 < mã số sinh viên < MaSoSinhVienToiDa
    public bool KiemTraNoiDungMaSoSinhVien(TextBox txtMSSV)
    {
        if (KiemTraNoiDungTextBox(txtMSSV))
        {
            // Cách tính MaSoSinhVienToiDa = 9999 + 10000 * Năm hiện tại
            int MaSoSinhVienToiDa = Convert.ToInt32(9999 + 10000 * DateTime.Now.Year);
            int mssv;
            bool kt = false;
            string nNhap = (txtMSSV.Text);
            kt = int.TryParse(nNhap, out mssv);
            if (!kt || mssv <= 0)
            {
                MessageBox.Show("Bạn đã nhập sai mã số sinh viên (phải là số nguyên dương).\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMSSV.Focus();
            }
            else
            {
                if (mssv > MaSoSinhVienToiDa || mssv < 19560000)
                {
                    MessageBox.Show("Bạn đã nhập sai mã số sinh viên.\nLưu ý: 19560000 < MSSV < " + MaSoSinhVienToiDa + "\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMSSV.Focus();
                    return false;
                }
                else
                {
                    if (KiemTraTrungMaSoSinhVien(mssv))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Lưu ý: Mã số sinh viên phải là duy nhất không được trùng.\nMã số sinh viên: " + mssv + " đã tồn tại trong danh sách.\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
        return false;
    }
    // Hàm kiểm tra người dùng nhập họ tên sinh viên
    public static bool KiemTraNoiDungHoTen(TextBox a)
    {
        if (KiemTraNoiDungTextBox(a))
        {
            if (!VietNamChar.KiemTraHoTen(a.Text))
            {
                a.Focus();
                return false;
            }
            return true;
        }
        return false;
    }
    // Hàm thêm sinh viên vào danh sách sinh viên khi ấn nút thêm sinh viên.
    public void ButtonThemSinhVien(TextBox txtMSSV, TextBox txtHoTen, DateTimePicker dateTimePicker1, TextBox txtKH, TextBox txtKV, TextBox txtLop, DataGridView dataGridViewDSSV, Label labelTongSoSinhVien)
    {
        //Tối ưu các    biểu thức điều kiện xét 3 điều kiện này trước đơn giản 
        if (KiemTraNoiDungTextBox(txtKH) && KiemTraNoiDungTextBox(txtKV) && KiemTraNoiDungTextBox(txtLop))
        {
            if (KiemTraNoiDungMaSoSinhVien(txtMSSV))
            {
                if (KiemTraNoiDungHoTen(txtHoTen))
                {
                    int mssv = Convert.ToInt32(txtMSSV.Text);
                    string ht = txtHoTen.Text.Trim();
                    DateTime ns = Convert.ToDateTime(dateTimePicker1.Text);
                    string kh = txtKH.Text;
                    string kv = txtKV.Text;
                    string l = txtLop.Text;
                    // Tạo sinh viên mới và thêm vào danh sách sinh viên
                    SinhVien newSinhVien = new SinhVien(mssv, ht, ns, kh, kv, l);
                    ThemSVCuoi(newSinhVien);
                    MessageBox.Show("Thêm thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Thêm thông tin sinh viên vào dataGridView
                    dataGridViewDSSV.Rows.Add(newSinhVien.ToString().Split(';'));
                    // Thay đổi tổng số lượng sinh viên trên Label
                    labelTongSoSinhVien.Text = "Tổng số sinh viện trong danh sách hiện tại: " + Convert.ToString(this.size);
                }
            }
        }
    }
    // Hàm hiển thị thông tin sinh viên khi chọn dòng thông tin sinh viên.
    public NodeSV HienThiThongTinSVKHiChon(TextBox txtMSSV, TextBox txtHoTen, DateTimePicker dateTimePicker1, TextBox txtKH, TextBox txtKV, TextBox txtLop, DataGridView dataGridViewDSSV, NodeSV LuuSinhVien, int i, Button sua, Button xoa)
    {
        int dem = -1;
        NodeSV iNode = this.headSV;
        // Vòng lặp danh sách
        while (iNode != null)
        {
            dem++;
            if (dem == i)
            {
                txtMSSV.Text = Convert.ToString(iNode.SV.MaSoSinhVien);
                txtHoTen.Text = iNode.SV.HoTen;
                dateTimePicker1.Text = Convert.ToDateTime(iNode.SV.NgaySinh).Day.ToString() + "/" + Convert.ToDateTime(iNode.SV.NgaySinh).Month.ToString() + "/" + Convert.ToDateTime(iNode.SV.NgaySinh).Year.ToString();
                txtKH.Text = iNode.SV.KhoaHoc;
                txtKV.Text = iNode.SV.KhoaVien;
                txtLop.Text = iNode.SV.Lop;
                break;
            }
            iNode = iNode.next;
        }
        // Hiện 2 nút chức năng sửa xóa khi đã chọn sinh viên
        sua.Enabled = true;
        xoa.Enabled = true;
        return iNode;
    }
    // Hàm sửa sinh viên khi ấn nút sửa sinh viên.
    public void ButtonSuaSinhVien(TextBox txtMSSV, TextBox txtHoTen, DateTimePicker dateTimePicker1, TextBox txtKH, TextBox txtKV, TextBox txtLop, DataGridView dataGridViewDSSV, NodeSV LuuSinhVien, int i)
    {
        if (isEmpty())
        {
            MessageBox.Show("Danh sách sinh viên hiện tại đang rỗng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            if (KiemTraNoiDungTextBox(txtMSSV) && KiemTraNoiDungTextBox(txtHoTen) && KiemTraNoiDungTextBox(txtKH) && KiemTraNoiDungTextBox(txtKV) && KiemTraNoiDungTextBox(txtLop))
            {
                int mssv = Convert.ToInt32(txtMSSV.Text);
                string ht = txtHoTen.Text.Trim();
                DateTime ns = Convert.ToDateTime(dateTimePicker1.Text);
                string kh = txtKH.Text;
                string kv = txtKV.Text;
                string l = txtLop.Text;
                // Tạo sinh viên mới để lưu giá trị thông tin sinh viên mới
                NodeSV SuaSinhVien = new NodeSV(new SinhVien(mssv, ht, ns, kh, kv, l), null, null);
                // Tìm sinh viên cần sửa trong LinkedList
                int dem = -1;
                NodeSV tempNode = this.headSV;
                while (tempNode != null)
                {
                    dem++;
                    if (tempNode.SV.MaSoSinhVien == LuuSinhVien.SV.MaSoSinhVien)
                    {
                        break;
                    }
                    tempNode = tempNode.next;
                }
                if (tempNode.SV.MaSoSinhVien == SuaSinhVien.SV.MaSoSinhVien)
                {
                    if (
                    tempNode.SV.HoTen == SuaSinhVien.SV.HoTen && tempNode.SV.NgaySinh == SuaSinhVien.SV.NgaySinh && tempNode.SV.KhoaHoc == SuaSinhVien.SV.KhoaHoc && tempNode.SV.KhoaVien == SuaSinhVien.SV.KhoaVien && tempNode.SV.Lop == SuaSinhVien.SV.Lop
                    )
                    {
                        MessageBox.Show("Thông tin sinh viên không thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        tempNode.SV.HoTen = SuaSinhVien.SV.HoTen;
                        tempNode.SV.NgaySinh = SuaSinhVien.SV.NgaySinh;
                        tempNode.SV.KhoaHoc = SuaSinhVien.SV.KhoaHoc;
                        tempNode.SV.KhoaVien = SuaSinhVien.SV.KhoaVien;
                        tempNode.SV.Lop = SuaSinhVien.SV.Lop;
                        // Thay đổi thông tin sinh viên hiển thị trên dataGridView
                        //   QLSV.MyDataGridView(DanhSachSinhVien, dataGridViewDanhSachSinhVien, labelTongSoSinhVien);
                        MessageBox.Show("Sửa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewDSSV.Rows.RemoveAt(i);
                        dataGridViewDSSV.Rows.Insert(i, tempNode.ToString().Split(';'));
                    }
                }
                else
                {
                    // Nếu sửa mã số sinh viên thì cần kiểm tra xem có bị trùng mã số sinh viên không
                    if (KiemTraTrungMaSoSinhVien(SuaSinhVien.SV.MaSoSinhVien))
                    {
                        tempNode.SV.MaSoSinhVien = SuaSinhVien.SV.MaSoSinhVien;
                        tempNode.SV.HoTen = SuaSinhVien.SV.HoTen;
                        tempNode.SV.NgaySinh = SuaSinhVien.SV.NgaySinh;
                        tempNode.SV.KhoaHoc = SuaSinhVien.SV.KhoaHoc;
                        tempNode.SV.KhoaVien = SuaSinhVien.SV.KhoaVien;
                        tempNode.SV.Lop = SuaSinhVien.SV.Lop;
                        // Thay đổi thông tin sinh viên hiển thị trên dataGridView
                        //  QLSV.MyDataGridView(DanhSachSinhVien, dataGridViewDanhSachSinhVien, labelTongSoSinhVien);
                        MessageBox.Show("Sửa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewDSSV.Rows.RemoveAt(i);
                        dataGridViewDSSV.Rows.Insert(i, tempNode.ToString().Split(';'));
                    }
                    else
                    {
                        MessageBox.Show("Thông tin sinh viên mới bị trùng\nMã số sinh viên: " + SuaSinhVien.SV.MaSoSinhVien + " đã tồn tại trong danh sách sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
    // Hàm xóa sinh viên khi ấn nút xóa sinh viên.
    public void ButtonXoaSinhVien(TextBox txtMSSV, TextBox txtHoTen, DateTimePicker dateTimePicker1, TextBox txtKH, TextBox txtKV, TextBox txtLop, DataGridView dataGridViewDSSV, Label labelTongSoSinhVien, NodeSV LuuSinhVien, int i, Button sua, Button xoa)
    {
        if (MessageBox.Show("Bạn có chắc chắn xóa sinh viên:\n" + LuuSinhVien.ToString() + "\n?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
        {
            XoaSVTheoVT(i);
            MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Thay đổi thông tin sinh viên trên các textbox
            txtMSSV.Text = "";
            txtHoTen.Text = "";
            txtKH.Text = "";
            txtKV.Text = "";
            txtLop.Text = "";
            // Thay đổi thông tin 2 nút chức năng vì chưa có đối tượng được chọn.
            sua.Enabled = false;
            xoa.Enabled = false;
            // Thay đổi thông tin sinh viên hiển thị trên dataGridView
            dataGridViewDSSV.Rows.RemoveAt(i);
            // Thay đổi tổng số lượng sinh viên trên Label
            labelTongSoSinhVien.Text = "Tổng số sinh viện trong danh sách hiện tại: " + Convert.ToString(this.size);
        }
    }
    // Hàm kiểm tra lựa chọn RadioButton
    public int HamKiemTraRadioButton(RadioButton a, RadioButton b, RadioButton c)
    {
        if (a.Checked)
        {
            return 1;
        }
        if (b.Checked)
        {
            return 2;
        }
        if (c.Checked)
        {
            return 3;
        }
        return 0;
    }
    // Hàm tìm sinh viên khi ấn nút tìm sinh viên.
    public void ButtonTimSinhVien(TextBox txtMSSV, TextBox txtHoTen, DateTimePicker dateTimePicker1, TextBox txtKH, TextBox txtKV, TextBox txtLop, DataGridView dataGridViewDSSV, Label labelTongSoSinhVien, NodeSV LuuSinhVien, int i, Button sua, Button xoa, RadioButton a, RadioButton b, RadioButton c, TextBox txtNoiDungTimKiem)
    {
        sua.Enabled = true;
        xoa.Enabled = true;
        if (isEmpty())
        {
            MessageBox.Show("Danh sách sinh viên hiện tại đang rỗng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            int CheDo = HamKiemTraRadioButton(a, b, c);
            switch (CheDo)
            {
                case 0:
                    MessageBox.Show("Bạn chưa chọn chế độ tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1:
                    int TimMSSV;
                    bool kt = false;
                    string nNhap = (txtNoiDungTimKiem.Text);
                    kt = int.TryParse(nNhap, out TimMSSV);
                    if (!kt || TimMSSV <= 0)
                    {
                        MessageBox.Show("Bạn đã nhập sai mã số sinh viên (phải là số nguyên dương).\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNoiDungTimKiem.Focus();
                    }
                    kt = false;
                    NodeSV currentSV = this.headSV;
                    int dem = 0;
                    // Đọc từng dòng cho đến hết thông tin sinh viên vào biến nội dung
                    while (currentSV != null)
                    {
                        dem++;
                        if (currentSV.SV.MaSoSinhVien == TimMSSV)
                        {
                            kt = true;
                            break;
                        }
                        currentSV = currentSV.next;
                    }
                    if (kt)
                    {
                        MessageBox.Show("Có tồn tại sinh viên: (MSSV: " + TimMSSV + ")\n\n" + currentSV.ToString() + "\n\nVị trí: dòng số " + dem, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại sinh viên MSSV:\n\n" + TimMSSV, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 2:
                    string TimHoTen = (txtNoiDungTimKiem.Text);
                    currentSV = this.headSV;
                    dem = 0;
                    int ViTri = 0;
                    kt = false;
                    string VanBan = "";
                    // Đọc từng dòng cho đến hết thông tin sinh viên vào biến nội dung
                    while (currentSV != null)
                    {
                        ViTri++;
                        if (currentSV.SV.HoTen == TimHoTen)
                        {
                            dem++;
                            VanBan += "\n" + currentSV.ToString() + "\nVị trí: dòng số " + ViTri + "\n";
                            kt = true;
                        }
                        currentSV = currentSV.next;
                    }
                    if (kt)
                    {
                        MessageBox.Show("Có tồn tại sinh viên: (TÊN: " + TimHoTen + ")\nSố lượng: " + dem + "\n\n" + VanBan + "\n", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại sinh viên tên:\n\n" + TimHoTen, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 3:
                    string TimLop = (txtNoiDungTimKiem.Text);
                    currentSV = this.headSV;
                    dem = 0;
                    kt = false;
                    VanBan = "";
                    // Đọc từng dòng cho đến hết thông tin sinh viên vào biến nội dung
                    while (currentSV != null)
                    {
                        if (currentSV.SV.Lop == TimLop)
                        {
                            dem++;
                            VanBan += currentSV.ToString() + "\n";
                            kt = true;
                        }
                        currentSV = currentSV.next;
                    }
                    if (kt)
                    {
                        MessageBox.Show("Có tồn tại sinh viên: (LỚP: " + TimLop + ")\nSố lượng: " + dem + "\n" + VanBan + "\n", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại sinh viên lớp:\n\n" + TimLop, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }
        }
    }
    // Hàm sắp xếp sinh viên khi ấn nút sắp xếp sinh viên.
    public void ButtonSX_SinhVien(DataGridView dataGridViewDSSV, Button sua, Button xoa, RadioButton a, RadioButton b, RadioButton c, int z)
    {
        sua.Enabled = true;
        xoa.Enabled = true;
        if (isEmpty())
        {
            MessageBox.Show("Danh sách sinh viên hiện tại đang rỗng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            int CheDo = HamKiemTraRadioButton(a, b, c);
            // z=1 hoặc 2
            int x = (z == 1) ? 1 : 2;
            // x= 1 2 
            switch (CheDo)
            {
                case 0:
                    MessageBox.Show("Bạn chưa chọn chế độ sắp xếp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1:
                    x = x;
                    // x= 1 2 
                    QuickSort(x);
                    MyDataGridView(dataGridViewDSSV);
                    MessageBox.Show("Sắp xếp sinh viên theo MSSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    x = x + 2;
                    // x= 3 4
                    QuickSort(x);
                    MyDataGridView(dataGridViewDSSV);
                    MessageBox.Show("Sắp xếp theo Họ và tên sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3:
                    x = x + 4;
                    // x= 5 6 
                    QuickSort(x);
                    MyDataGridView(dataGridViewDSSV);
                    MessageBox.Show("Sắp xếp sinh viên theo lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
    }
    // Hàm sắp xếp sử dụng QuickSort và kĩ thuật đệ qui 
    void QuickSort(int x)
    {
        LinkedListQuanLiSinhVien DS1 = new LinkedListQuanLiSinhVien();
        LinkedListQuanLiSinhVien DS2 = new LinkedListQuanLiSinhVien();
        NodeSV tagSV, tempSV;
        if (this.headSV == this.tailSV) return;
        tagSV = this.headSV;
        this.headSV = this.headSV.next;
        tagSV.next = null;
        while (this.headSV != null)
        {
            tempSV = this.headSV;
            this.headSV = this.headSV.next;
            tempSV.next = null;
            switch (x)
            {
                case 1:
                    if (tempSV.SV.MaSoSinhVien <= tagSV.SV.MaSoSinhVien)
                    {
                        DS1.ThemSVCuoi(tempSV.SV);
                    }
                    else
                    {
                        DS2.ThemSVCuoi(tempSV.SV);
                    }
                    break;
                case 2:
                    if (tempSV.SV.MaSoSinhVien >= tagSV.SV.MaSoSinhVien)
                    {
                        DS1.ThemSVCuoi(tempSV.SV);
                    }
                    else
                    {
                        DS2.ThemSVCuoi(tempSV.SV);
                    }
                    break;
                case 3:
                    if (VietNamChar.SoSanhHoTen(tempSV.SV.HoTen, tagSV.SV.HoTen) == 1)
                    {
                        DS1.ThemSVCuoi(tempSV.SV);
                    }
                    else
                    {
                        DS2.ThemSVCuoi(tempSV.SV);
                    }
                    break;
                case 4:
                    if (VietNamChar.SoSanhHoTen(tempSV.SV.HoTen, tagSV.SV.HoTen) == 0)
                    {
                        DS1.ThemSVCuoi(tempSV.SV);
                    }
                    else
                    {
                        DS2.ThemSVCuoi(tempSV.SV);
                    }
                    break;
                case 5:
                    if (HashTable.HashFunction(tempSV.SV.Lop) <= HashTable.HashFunction(tagSV.SV.Lop))
                    {
                        DS1.ThemSVCuoi(tempSV.SV);
                    }
                    else
                    {
                        DS2.ThemSVCuoi(tempSV.SV);
                    }
                    break;
                case 6:
                    if (HashTable.HashFunction(tempSV.SV.Lop) >= HashTable.HashFunction(tagSV.SV.Lop))
                    {
                        DS1.ThemSVCuoi(tempSV.SV);
                    }
                    else
                    {
                        DS2.ThemSVCuoi(tempSV.SV);
                    }
                    break;
            }
        }
        DS1.QuickSort(x);
        DS2.QuickSort(x);
        if (DS1.headSV != null)
        {
            this.headSV = DS1.headSV;
            DS1.tailSV.next = tagSV;
        }
        else
        {
            this.headSV = tagSV;
        }
        tagSV.next = DS2.headSV;
        if (DS2.headSV != null)
        {
            this.tailSV = DS2.tailSV;
        }
        else
        {
            this.tailSV = tagSV;
        }
    }
    // Hàm hiển thị trên DataGridView theo danh sánh đang có hiện tại
    void MyDataGridView(DataGridView dataGridViewDSSV)
    {
        dataGridViewDSSV.Rows.Clear();
        NodeSV currentSV = this.headSV;
        while (currentSV != null)
        {
            dataGridViewDSSV.Rows.Add(currentSV.ToString().Split(';'));
            currentSV = currentSV.next;
        }
    }
}