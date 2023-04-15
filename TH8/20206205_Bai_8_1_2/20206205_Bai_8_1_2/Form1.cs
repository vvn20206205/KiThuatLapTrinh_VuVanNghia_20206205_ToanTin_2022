using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20206205_Bai_8_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HamAnPhepTinh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HamThem(button1);
            HamHienPhepTinh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HamThem(button2);
            HamHienPhepTinh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HamThem(button3);
            HamHienPhepTinh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HamThem(button4);
            HamHienPhepTinh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HamThem(button5);
            HamHienPhepTinh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HamThem(button6);
            HamHienPhepTinh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HamThem(button7);
            HamHienPhepTinh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HamThem(button8);
            HamHienPhepTinh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            HamThem(button9);
            HamHienPhepTinh();
        }

        private void buttonMo_Click(object sender, EventArgs e)
        {
            HamThem(buttonMo);
            HamHienPhepTinh();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            HamThem(button0);
            HamHienPhepTinh();
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            HamThem(buttonDong);
            HamHienPhepTinh();
        }

        private void buttonCong_Click(object sender, EventArgs e)
        {
            HamThem(buttonCong);
            HamAnPhepTinh();
        }

        private void buttonTru_Click(object sender, EventArgs e)
        {
            HamThem(buttonTru);
            HamAnPhepTinh();
        }

        private void buttonNhan_Click(object sender, EventArgs e)
        {
            HamThem(buttonNhan);
            HamAnPhepTinh();
        }

        private void buttonChia_Click(object sender, EventArgs e)
        {
            HamThem(buttonChia);
            HamAnPhepTinh();
        }
        // Hàm thêm khi bấm
        public void HamThem(Button a)
        {
            textBoxBieuThuc.Text += a.Text;
        }
        // Hàm ẩn phép tính +,-,x,/ khi bấm 1 phép tính trước
        public void HamAnPhepTinh()
        {
            buttonCong.Enabled = false;
            buttonTru.Enabled = false;
            buttonNhan.Enabled = false;
            buttonChia.Enabled = false;
            buttonTinhToan.Enabled = false;
        }
        // Hàm hiện lại phép tính +,-,x,/
        public void HamHienPhepTinh()
        {
            buttonCong.Enabled = true;
            buttonTru.Enabled = true;
            buttonNhan.Enabled = true;
            buttonChia.Enabled = true;
            buttonTinhToan.Enabled = true;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (textBoxBieuThuc.Text.Length == 0)
            {
                MessageBox.Show("Biểu thức trống!\nKhông thể xóa nữa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBoxBieuThuc.Text = textBoxBieuThuc.Text.Remove(textBoxBieuThuc.Text.Length - 1);
                HamHienPhepTinh();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            HamHienPhepTinh();
            textBoxBieuThuc.Text = "";
        }

        private void buttonTinhToan_Click(object sender, EventArgs e)
        {
            HamHienPhepTinh();
            if (textBoxBieuThuc.Text == "")
            {
                MessageBox.Show("Biểu thức trống!\nKhông cần tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // thực hiện tính
                try
                {
                    textBoxKetQua.Text = TinhBieuThucTrungTo(textBoxBieuThuc.Text).ToString();

                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra!\nBiểu thức không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
        // Hàm xử lí tính toán bằng Stack
        public static int TinhBieuThucTrungTo(string infix)
        {
            var StackPhepTinh = new MyLinkedListStackChar();
            var StackSo = new MyLinkedListStackInt();

            var precedence = new Dictionary<char, int> { { '(', 0 }, { '*', 1 }, { '/', 1 }, { '+', 2 }, { '-', 2 }, { ')', 3 } };

            foreach (var ch in $"({infix})")
            {
                switch (ch)
                {
                    case var digit when Char.IsDigit(digit):
                        StackSo.Push(Convert.ToInt32(digit.ToString()));
                        break;
                    case var op when precedence.ContainsKey(op):
                        var keepLooping = true;
                        while (keepLooping && StackPhepTinh.Count() > 0 && precedence[ch] > precedence[StackPhepTinh.Peek()])
                        {
                            switch (StackPhepTinh.Peek())
                            {
                                case '+':
                                    StackSo.Push(StackSo.Pop() + StackSo.Pop());
                                    break;
                                case '-':
                                    StackSo.Push(-StackSo.Pop() + StackSo.Pop());
                                    break;
                                case '*':
                                    StackSo.Push(StackSo.Pop() * StackSo.Pop());
                                    break;
                                case '/':
                                    var divisor = StackSo.Pop();
                                    StackSo.Push(StackSo.Pop() / divisor);
                                    break;
                                case '(':
                                    keepLooping = false;
                                    break;
                            }
                            if (keepLooping)
                                StackPhepTinh.Pop();
                        }
                        if (ch == ')')
                            StackPhepTinh.Pop();
                        else
                            StackPhepTinh.Push(ch);
                        break;
                    default:
                        throw new ArgumentException();
                }
            }

            if (StackPhepTinh.Count() > 0 || StackSo.Count() > 1)
                throw new ArgumentException();
            return StackSo.Pop();
        }
    }
}
